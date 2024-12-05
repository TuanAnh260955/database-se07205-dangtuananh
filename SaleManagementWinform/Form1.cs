using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace SaleManagementWinform
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            // Đặt biểu mẫu bắt đầu ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // Vô hiệu hóa nút tối đa hóa/khôi phục
            this.MaximizeBox = false;

            // Tùy chọn: Đặt kiểu đường viền cố định để ngăn chặn việc thay đổi kích thước
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txbusername.Text;
            string password = txbpassword.Text;

            string hashPassword = Utils.HashPassword(password);

            bool checkLogin = CheckLogin(username, hashPassword);

            if (checkLogin)
            {

                MenuForm main = new MenuForm();
                main.Show();
                this.Hide();

            }
            else
            {


                MessageBox.Show("Username or password is incorrect !");
            }
        }
        private bool CheckLogin(string username, string hashedPassword)
        {
            string query = "SELECT password FROM Employee WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString(); // Retrieved hashed password
                        return storedHash == hashedPassword;  // Compare the hashes
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return false; // Return false if username not found or any error occurs
        }
        public static class Connection
        {
            public static string SQLConnection = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        }
        public static class Utils
        {
            public static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashBytes = sha256.ComputeHash(bytes);
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        builder.Append(b.ToString("x2")); // Convert to hexadecimal
                    }
                    return builder.ToString();
                }
            }
        }
    }
}
