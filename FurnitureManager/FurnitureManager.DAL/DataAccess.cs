using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Data;

namespace FurnitureManager.DAL
{
    public class DataAccess
    {
        private string connString;
        public DataAccess()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }



        public User GetUser(string username, string password)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                conn.Open();
                string statement = "SELECT * FROM users where username='username'  and password=SHA('password')";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
               
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.Name = reader.GetString("Name");
                        user.Address = reader.GetString("Address");
                        user.Username = reader.GetString("Username");
                        user.Password = reader.GetString("Password");
                        user.IsAdmin = reader.GetBoolean("isAdmin");


                        return user;
                    }
                }
            }
            return null;
        }

              
            
        

        public IList<User> RetrieveUsers()
        {
            IList<User> usersList = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM users";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.Name = reader.GetString("Name");
                        user.Address = reader.GetString("Address");
                        user.Username = reader.GetString("Username");
                        user.Password = reader.GetString("Password");
                        user.IsAdmin = reader.GetBoolean("isAdmin");
                        
                        usersList.Add(user);
                    }
                }
            }

            return usersList;
        }

        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO users(id, name, address, username, password, isAdmin) VALUES(@id, @name, @address, @username, @password, @isAdmin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE users SET name = @name, address = @address, username= @username, password=@password, isAdmin=@isAdmin  WHERE id = @id;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM users WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.ExecuteNonQuery();



            }
       
        
        }

        public IList<Order> RetrieveOrders()
        {
            IList<Order> ordersList = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM orders";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Order orders = new Order();
                        orders.ID = reader.GetInt32("ID");
                        orders.Customer = reader.GetString("Customer");
                        orders.Address = reader.GetString("Address");
                        orders.Date = reader.GetDateTime("Date");
                        orders.Status = reader.GetString("Status");
                       // orders.Product = reader.("Product");
                        ordersList.Add(orders);
                    }
                }
            }

            return ordersList;
        }

        public void AddOrder(Order orders)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO orders(id, customer, date, address, status) VALUES(@id, @customer, @date, @address, @status)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", orders.ID);
                cmd.Parameters.AddWithValue("@customer", orders.Customer);
                cmd.Parameters.AddWithValue("@date", orders.Date);
                cmd.Parameters.AddWithValue("@address", orders.Address);
                cmd.Parameters.AddWithValue("@status", orders.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(Order orders)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE orders SET customer = @customer, date = @date, address= @address, status=@status  WHERE id = @id;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", orders.ID);
                cmd.Parameters.AddWithValue("@customer", orders.Customer);
                cmd.Parameters.AddWithValue("@date", orders.Date);
                cmd.Parameters.AddWithValue("@address", orders.Address);
                cmd.Parameters.AddWithValue("@status", orders.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public IList<Product> RetrieveProducts()
        {
            IList<Product> productsList = new List<Product>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ID = reader.GetInt32("ID");
                        product.Title = reader.GetString("Title");
                        product.Description = reader.GetString("Description");
                        product.Color = reader.GetString("Color");
                        product.Size = reader.GetString("Size");
                        product.Price = reader.GetInt32("Price");
                        product.Stock = reader.GetInt32("Stock");
                        productsList.Add(product);
                    }
                }
            }

            return productsList;
        }

        public void AddProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product(id, title, description, color, size, price, stock) VALUES(@id, @title, @description, @color, @size, @price, @stock)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product SET title = @title, description = @description, color= @color, size=@size, price=@price, stock=@stock  WHERE id = @id;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();



            }
        }

    }
}
