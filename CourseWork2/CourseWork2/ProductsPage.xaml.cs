using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Npgsql;

namespace CourseWork2
{
    public partial class ProductsPage : Page
    {
        private DB db;
        private int userId;
        private List<int> orderedProductIds = new List<int>();

        public ProductsPage(int userId)
        {
            InitializeComponent();
            db = new DB();
            LoadCategories();
            this.userId = userId;
            
        }

        private void LoadCategories()
        {
            try
            {
                List<string> categories = db.GetCategories();
                CategoriesListBox.ItemsSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження категорій: " + ex.Message);
            }
        }

        private void CategoriesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoriesListBox.SelectedItem != null)
            {
                string selectedCategory = CategoriesListBox.SelectedItem.ToString();
                LoadProductsByCategory(selectedCategory);
            }
        }

        private void LoadProductsByCategory(string categoryName)
        {
            try
            {
                string query = @"
                    SELECT product_id AS product_id, 
                           product_name AS Назва, 
                           brand AS Бренд, 
                           price AS Ціна, 
                           stock_quantity AS Кількість, 
                           description AS Опис
                    FROM products
                    WHERE category_name = @categoryName";

                using (NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection()))
                {
                    command.Parameters.AddWithValue("@categoryName", categoryName);

                    DataTable products = new DataTable();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(products);

                    ProductsDataGrid.ItemsSource = products.DefaultView;

                    ClearProductDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження товарів: " + ex.Message);
            }
        }

        private void ProductsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsDataGrid.SelectedItem is DataRowView rowView)
            {
                ProductNameTextBlock.Text = rowView["Назва"]?.ToString() ?? "Невідомо";
                ProductBrandTextBlock.Text = rowView["Бренд"]?.ToString() ?? "Невідомо";
                ProductPriceTextBlock.Text = rowView["Ціна"]?.ToString() + " грн" ?? "Невідомо";
                ProductStockTextBlock.Text = rowView["Кількість"]?.ToString() ?? "Невідомо";
                ProductDescriptionTextBlock.Text = rowView["Опис"]?.ToString() ?? "Немає опису";
            }
            else
            {
                ClearProductDetails();
            }
        }

        private void ClearProductDetails()
        {
            ProductNameTextBlock.Text = "";
            ProductBrandTextBlock.Text = "";
            ProductPriceTextBlock.Text = "";
            ProductStockTextBlock.Text = "";
            ProductDescriptionTextBlock.Text = "";
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ProductsDataGrid.SelectedItem as DataRowView;

            if (selectedProduct != null)
            {
                int productId = Convert.ToInt32(selectedProduct["product_id"]);
                if (!orderedProductIds.Contains(productId))
                {
                    orderedProductIds.Add(productId);
                }

                MessageBox.Show("Товар додано до замовлення!");
                ProductsDataGrid.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть товар для замовлення.");
            }
        }

        private void ViewOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            if (orderedProductIds.Count > 0)
            {
                UserOrder userOrderPage = new UserOrder();
                this.NavigationService.Navigate(userOrderPage);
            }
            else
            {
                MessageBox.Show("Немає замовлених товарів для перегляду.");
            }
        }
    }
}
