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
    public partial class AddProductForm : Form
    {
        public static string connectionString
       = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";

        public AddProductForm()
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           



        }


        private void InsertData(string code, string name, int quantity, int price)
        {
            string query = "INSERT INTO Product (Code, Name, Quantity, Price, active) VALUES (@Code, @Name, @Quantity, @Price, 1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào SqlCommand
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Price", price);

                        // Thực hiện câu lệnh
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MaSP = txb_code.Text.Trim();
                string TenSP = txb_name.Text.Trim();
                int SoLuong = int.Parse(txb_quantity.Text.Trim());
                int Gia = int.Parse(txb_price.Text.Trim());

                if (string.IsNullOrEmpty(MaSP) || string.IsNullOrEmpty(TenSP) || SoLuong < 0 || Gia < 0)
                {
                    MessageBox.Show("Please fill in all fields correctly.");
                    return;
                }

                InsertData(MaSP, TenSP, SoLuong, Gia);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for quantity and price.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string MaSP = txb_code.Text.ToString();
            string TenSP = txb_name.Text.ToString();
            int SoLuong = int.Parse(txb_quantity.Text.ToString());
            int Gia = int.Parse(txb_price.Text.ToString());

            InsertData(MaSP, TenSP, SoLuong, Gia);
        }
        private void DeleteProductFromDatabase(string code)
        {
            string deletePurchaseHistoryQuery = "DELETE FROM PurchaseHistory WHERE Code = @Code";
            string deleteProductQuery = "DELETE FROM Product WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Xóa các bản ghi trong PurchaseHistory
                        using (SqlCommand command = new SqlCommand(deletePurchaseHistoryQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Code", code);
                            command.ExecuteNonQuery();
                        }

                        // Xóa sản phẩm
                        using (SqlCommand command = new SqlCommand(deleteProductQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Code", code);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No product found with the specified code.");
                            }
                        }

                        // Commit transaction
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm từ TextBox
            string productCode = txb_code.Text.Trim(); // Giả sử bạn sử dụng txb_code để nhập mã sản phẩm

            if (!string.IsNullOrEmpty(productCode))
            {
                // Gọi phương thức xóa
                DeleteProductFromDatabase(productCode);
            }
            else
            {
                MessageBox.Show("Please enter a product code to delete.");
            }
        }
    }
}
