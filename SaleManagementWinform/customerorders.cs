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
    public partial class customerorders : Form
    {
        public static string SQLConnection = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public customerorders()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Hiển thị toàn màn hình
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += new System.EventHandler(this.customerorders_Load);

        }
        private void OrderProduct(int productCode, string productName, decimal price, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    string query = "INSERT INTO Orders (ProductCode, ProductName, Price, Quantity, OrderDate) " +
                                   "VALUES (@ProductCode, @ProductName, @Price, @Quantity, GETDATE())";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductCode", productCode);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Order placed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(SQLConnection))
            {
                try
                {
                    string query = "SELECT * FROM Orders"; // Kiểm tra xem bảng Orders có tồn tại không
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable orderTable = new DataTable();
                    adapter.Fill(orderTable);

                    if (orderTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No orders found in the database.");
                    }

                    dgv_customeroders.DataSource = orderTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading orders: {ex.Message}");
                }
            }
        }

        private void customerorders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private bool CheckStock(int productCode, int orderQuantity)
        {
            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    string query = "SELECT Quantity FROM Products WHERE Code = @ProductCode";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductCode", productCode);

                    connection.Open();
                    int stock = Convert.ToInt32(command.ExecuteScalar());
                    return stock >= orderQuantity;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }
    }
}
