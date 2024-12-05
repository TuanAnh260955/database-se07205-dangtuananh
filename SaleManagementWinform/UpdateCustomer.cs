using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleManagementWinform
{
    public partial class UpdateCustomer : Form
    {
        public static string connectionString
       = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public UpdateCustomer(string code, string name, string phonenumber, string address, string email)
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;
            txb_code.Text = code;
            txb_name.Text = name;
            txb_phonenumber.Text = phonenumber.ToString();
            txb_address.Text = address.ToString();
            txb_email.Text = email.ToString();

        }
        private void UpdateCustomerInDatabase(string code, string name, string phonenumber, string address, string email)
        {
            string query = "UPDATE Customer SET Name = @Name, PhoneNumber = @PhoneNumber, Address = @Address, Email = @Email WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void DeleteProductFromDatabase(string code)
        {
            string query = "DELETE FROM Product WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);

                        // Execute the delete command
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra và lấy thông tin từ TextBox
            if (string.IsNullOrWhiteSpace(txb_code.Text) ||
                string.IsNullOrWhiteSpace(txb_name.Text) ||
                string.IsNullOrWhiteSpace(txb_phonenumber.Text) ||
                string.IsNullOrWhiteSpace(txb_address.Text) ||
                string.IsNullOrWhiteSpace(txb_email.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin khách hàng.");
                return;
            }

            // Gọi phương thức cập nhật
            UpdateCustomerInDatabase(txb_code.Text, txb_name.Text, txb_phonenumber.Text, txb_address.Text, txb_email.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the product code from the textbox
            string code = txb_code.Text.Trim();

            // Confirm before deleting
            var confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the product from the database
                DeleteProductFromDatabase(code);
            }
        }
    }
}
