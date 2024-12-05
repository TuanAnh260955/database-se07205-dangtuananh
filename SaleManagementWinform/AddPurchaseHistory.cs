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
    public partial class AddPurchaseHistory : Form
    {
        public static string connectionString = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public AddPurchaseHistory()
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
            try
            {
                string purchaseID = txb_PurchaseID.Text.Trim();
                string customerCode = txb_CustomerCode.Text.Trim();
                string productCode = txb_Code.Text.Trim();
                DateTime purchaseDate = DateTime.Parse(txb_PurchaseDate.Text.Trim());
                int quantity = int.Parse(txb_Quantity.Text.Trim());

                if (string.IsNullOrEmpty(purchaseID) || string.IsNullOrEmpty(customerCode) ||
                    string.IsNullOrEmpty(productCode) || quantity < 0)
                {
                    MessageBox.Show("Please fill in all fields correctly.");
                    return;
                }

                InsertPurchaseHistory(purchaseID, customerCode, productCode, purchaseDate, quantity);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for quantity and a valid date.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void InsertPurchaseHistory(string purchaseID, string customerCode, string productCode, DateTime purchaseDate, int quantity)
        {
            string query = "INSERT INTO PurchaseHistory (PurchaseID, CustomerCode, Code, PurchaseDate, Quantity) VALUES (@PurchaseID, @CustomerCode, @Code, @PurchaseDate, @Quantity)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@PurchaseID", purchaseID);
                        command.Parameters.AddWithValue("@CustomerCode", customerCode);
                        command.Parameters.AddWithValue("@Code", productCode);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        // Execute the insert command
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

        private void button2_Click(object sender, EventArgs e)
        {
            string purchaseID = txb_PurchaseID.Text.Trim(); // Giả sử bạn sử dụng txb_PurchaseID để nhập ID giao dịch mua

            if (!string.IsNullOrEmpty(purchaseID))
            {
                DeletePurchaseHistory(purchaseID);
            }
            else
            {
                MessageBox.Show("Please enter a purchase ID to delete.");
            }
        }
        private void DeletePurchaseHistory(string purchaseID)
        {
            string deleteQuery = "DELETE FROM PurchaseHistory WHERE PurchaseID = @PurchaseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PurchaseID", purchaseID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Purchase history deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No purchase history found with the specified ID.");
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

