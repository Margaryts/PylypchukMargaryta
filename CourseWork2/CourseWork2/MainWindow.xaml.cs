using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using CourseWork2;
using Npgsql;

namespace CourseWork2
{
    public partial class MainWindow : Window
    {
        DB db = new DB();

        public MainWindow()
        {
            InitializeComponent();  
        }

        private void Button_Avt_Click(object sender, RoutedEventArgs e)
        {
            string full_name = textBoxFullName.Text.Trim();
            string password = passwordBox.Password.Trim();

            if (string.IsNullOrEmpty(full_name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter login and password.");
                return;
            }

            string query = "SELECT user_id FROM users WHERE full_name = @full_name AND password = @password";

            try
            {
                db.OpenConnection();
                using (NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection()))
                {
                    command.Parameters.AddWithValue("@full_name", full_name);
                    command.Parameters.AddWithValue("@password", password);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        MessageBox.Show("Login successful!");

                        // Передаємо userId у ProductsPage
                        ProductsPage productsPage = new ProductsPage(userId);
                        MainFrame.Navigate(productsPage);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect login or password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void But_Register(object sender, RoutedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            MainFrame.Navigate(registerPage); 
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
