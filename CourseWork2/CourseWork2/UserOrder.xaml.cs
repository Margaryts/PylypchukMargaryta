using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork2
{
    /// <summary>
    /// Interaction logic for UserOrder.xaml
    /// </summary>
    public partial class UserOrder : Page
    {
        private DB db = new DB();

        public UserOrder()
        {
            InitializeComponent();
            Loaded += Page_Loaded;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                DataTable ordersTable = db.GetOrders();
                OrdersDataGrid.ItemsSource = ordersTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження замовлень: {ex.Message}", "Помилка");
            }
            var orders = OrderManager.GetOrders();
            OrdersDataGrid.ItemsSource = orders;
        }

        private void DeleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = OrdersDataGrid.SelectedItem as Order;

            if (selectedOrder != null)
            {
                OrderManager.RemoveOrder(selectedOrder);
                MessageBox.Show("Замовлення успішно видалено!");

                LoadOrders();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть замовлення для видалення.");
            }
        }

        private void RefreshOrders_Click(object sender, RoutedEventArgs e)
        {
            LoadOrders();
        }

    }

}
