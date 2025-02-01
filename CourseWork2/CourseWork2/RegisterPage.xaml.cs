using System;
using System.Windows;
using CourseWork2;
using System.Windows.Controls;
using Npgsql;
using System.Linq;

namespace CourseWork2
{
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string[] inputs =
            {
                textBoxFullName.Text.Trim(),
                textBoxEmail.Text.Trim(),
                passwordBox.Password.Trim(),
                phoneBox.Text.Trim()
            };

            if (inputs.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }

            string fullName = inputs[0];
            string email = inputs[1];
            string password = inputs[2];
            string phone = inputs[3];

            try
            {
                DB db = new DB();
                db.OpenConnection();

                string query = "INSERT INTO users (full_name, email, password, phone) VALUES (@fullName, @Email, @Password, @Phone)";

                using (var command = new NpgsqlCommand(query, db.GetConnection()))
                {
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Phone", phone);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        this.NavigationService.Navigate(new MainWindow());
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
