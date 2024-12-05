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
using static SaleManagementWinform.Form1;

namespace SaleManagementWinform
{
    public partial class SearchProduct : Form
    {
        public static string connectionString
       = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchProductByCodeAndName(string code, string name)
        {
            string query = "SELECT * FROM Product WHERE Code = @Code OR Name = @Name";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open(); // Mở kết nối
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string productCode = reader["Code"].ToString();
                                    string productName = reader["Name"].ToString();
                                    int quantity = reader["Quantity"] != DBNull.Value ? (int)reader["Quantity"] : 0; // Kiểm tra null
                                    int price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetInt32(reader.GetOrdinal("Price"));

                                    MessageBox.Show($"Code: {productCode}, Name: {productName}, Quantity: {quantity}, Price: {price}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No product found.");
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
            string code = textBoxCode.Text.Trim(); // Giả sử bạn có TextBox cho mã sản phẩm
            string name = textBoxName.Text.Trim(); // Giả sử bạn có TextBox cho tên sản phẩm

            SearchProductByCodeAndName(code, name); // Gọi phương thức
        }
    }
}
