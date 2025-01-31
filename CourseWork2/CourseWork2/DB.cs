using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace CourseWork2
{
    public class DB
    {
        private NpgsqlConnection connection;

        public DB()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=396458;Database=InternetShop";
            connection = new NpgsqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            string query = "SELECT category_name FROM categories";

            try
            {
                OpenConnection();

                using (var cmd = new NpgsqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(reader.GetString(0));
                    }
                }

                Console.WriteLine($"Categories loaded: {categories.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving categories: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return categories;
        }

        public DataTable GetProductsByCategory(string categoryName)
        {
            string query = "SELECT product_name AS \"Назва товару\", " +
                           "brand AS \"Бренд\", " +
                           "price AS \"Ціна\", " +
                           "stock_quantity AS \"Кількість на складі\", " +
                           "description AS \"Опис\" " +
                           "FROM products " +
                           "WHERE products.category_name = @categoryName";

            DataTable table = new DataTable();

            try
            {
                OpenConnection();

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@categoryName", categoryName);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving products: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return table;
        }
        public DataTable GetOrders()
        {
            string query = "SELECT order_id, user_id, order_date, total_amount, status FROM orders ORDER BY order_id ASC";

            DataTable dt = new DataTable();
            OpenConnection();

            using (var cmd = new NpgsqlCommand(query, connection))
            {
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            CloseConnection();
            return dt;
        }
        public void DeleteOrder(int orderId)
        {
            string query = "DELETE FROM orders WHERE order_id = @orderId";

            OpenConnection();

            using (var cmd = new NpgsqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.ExecuteNonQuery();
            }

            CloseConnection();
        }

    }
}
