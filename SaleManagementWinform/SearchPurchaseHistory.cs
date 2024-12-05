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
    public partial class SearchPurchaseHistory : Form
    {
        public static string connectionString = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";

        public SearchPurchaseHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string purchaseID = textBoxPurchaseID.Text.Trim(); // Giả sử bạn có TextBox cho PurchaseID
            SearchPurchaseByID(purchaseID); // Gọi phương thức tìm kiếm
        }
        private void SearchPurchaseByID(string purchaseID)
        {
            string query = "SELECT * FROM PurchaseHistory WHERE PurchaseID = @PurchaseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Mở kết nối
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PurchaseID", purchaseID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Lấy thông tin từ mỗi bản ghi
                                    string id = reader["PurchaseID"].ToString();
                                    string customerCode = reader["CustomerCode"].ToString();
                                    string productCode = reader["Code"].ToString();
                                    DateTime purchaseDate = reader.GetDateTime(reader.GetOrdinal("PurchaseDate"));
                                    int quantity = reader.IsDBNull(reader.GetOrdinal("Quantity")) ? 0 : reader.GetInt32(reader.GetOrdinal("Quantity"));

                                    // Hiển thị thông tin trong MessageBox hoặc lưu vào một Control khác
                                    MessageBox.Show($"Purchase ID: {id}, Customer Code: {customerCode}, Product Code: {productCode}, Purchase Date: {purchaseDate.ToShortDateString()}, Quantity: {quantity}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No purchase found with the specified ID.");
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
    }
}

