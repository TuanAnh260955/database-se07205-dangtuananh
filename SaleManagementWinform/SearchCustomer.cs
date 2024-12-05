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

namespace SaleManagementWinform
{
    public partial class SearchCustomer : Form
    {
        public static string connectionString = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SearchCustomerByCode(string code)
        {
            string query = "SELECT * FROM Customer WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Mở kết nối
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string customerCode = reader["Code"].ToString();
                                    string customerName = reader["Name"].ToString();
                                    string phoneNumber = reader["PhoneNumber"].ToString();
                                    string address = reader["Address"].ToString();
                                    string email = reader["Email"].ToString();

                                    MessageBox.Show($"Code: {customerCode}, Name: {customerName}, Phone: {phoneNumber}, Address: {address}, Email: {email}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No customer found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBoxCode.Text.Trim(); // TextBox cho mã khách hàng
            SearchCustomerByCode(code); // Gọi phương thức
        }
    }
}

