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
    public partial class UpdatePurchaseHistory : Form
    {
        public static string connectionString = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public UpdatePurchaseHistory(string purchaseID, string customerCode, string productCode, DateTime purchaseDate, int quantity)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            // Set initial values in the textboxes
            txb_PurchaseID.Text = purchaseID;
            txb_CustomerCode.Text = customerCode;
            txb_Code.Text = productCode;
            txb_PurchaseDate.Text = purchaseDate.ToString("yyyy-MM-dd");
            txb_Quantity.Text = quantity.ToString();
        }
        private void UpdatePurchaseInDatabase(string purchaseID, string customerCode, string productCode, DateTime purchaseDate, int quantity)
        {
            string query = "UPDATE PurchaseHistory SET CustomerCode = @CustomerCode, Code = @Code, PurchaseDate = @PurchaseDate, Quantity = @Quantity WHERE PurchaseID = @PurchaseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PurchaseID", purchaseID);
                        command.Parameters.AddWithValue("@CustomerCode", customerCode);
                        command.Parameters.AddWithValue("@Code", productCode);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Purchase updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No purchase found with the specified ID.");
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
            if (string.IsNullOrWhiteSpace(txb_PurchaseID.Text) ||
                string.IsNullOrWhiteSpace(txb_CustomerCode.Text) ||
                string.IsNullOrWhiteSpace(txb_Code.Text) ||
                !DateTime.TryParse(txb_PurchaseDate.Text, out DateTime purchaseDate) ||
                !int.TryParse(txb_Quantity.Text, out int quantity))
            {
                MessageBox.Show("Please check the product information.");
                return;
            }
            UpdatePurchaseInDatabase(txb_PurchaseID.Text, txb_CustomerCode.Text, txb_Code.Text, purchaseDate, quantity);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txb_PurchaseID.Clear();
            txb_CustomerCode.Clear();
            txb_Code.Clear();
            txb_PurchaseDate.Clear();
            txb_Quantity.Clear();
        }
    }
}
