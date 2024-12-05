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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace SaleManagementWinform
{
    public partial class UpdateEmployee : Form
    {
        public static string connectionString = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        
        public UpdateEmployee(string code, string fullName, string position, string role, string username, string password)
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Initialize TextBox with existing employee data
            txb_code.Text = code;
            txb_Name.Text = fullName;
            txb_position.Text = position;
            if (role == "Admin") radioButtonAdmin.Checked = true;
            else if (role == "Warehouse") radioButtonWarehouse.Checked = true;
            else if (role == "Sale") radioButtonSale.Checked = true;
            else if (role == "Customer") radioButtonCustomer.Checked = true;
            txb_username.Text = username;
            txb_password.Text = password;
        }

        private void UpdateEmployeeInDatabase(string code, string fullName, string position, int roleId, string username, string password)
        {
            string query = "UPDATE Employee SET name = @Name, position = @Position, roleid = @RoleId, username = @Username, password = @Password WHERE code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", Name); // Sử dụng 'name' thay vì 'FullName'
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@RoleId", roleId); // Sử dụng 'roleid' thay vì 'Role'
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the specified code.");
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
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txb_code.Text) ||
                string.IsNullOrWhiteSpace(txb_Name.Text) ||
                string.IsNullOrWhiteSpace(txb_position.Text) ||
                string.IsNullOrWhiteSpace(txb_username.Text) ||
                string.IsNullOrWhiteSpace(txb_password.Text))
            {
                MessageBox.Show("Please check the employee information.");
                return;
            }

            string role = GetSelectedRole(); // Giả sử bạn có phương thức này để lấy vai trò đã chọn
            MessageBox.Show($"Selected role: '{role}'");
            // Lấy roleId
            int roleId = GetRoleId(role);
            try
            {
                roleId = GetRoleId(role);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            // Cập nhật thông tin nhân viên
            UpdateEmployeeInDatabase(txb_code.Text, txb_Name.Text, txb_position.Text, roleId, txb_username.Text, txb_password.Text);
            this.Close();

        }
        private string GetSelectedRole()
        {
            if (radioButtonAdmin.Checked) return "admin";
            if (radioButtonWarehouse.Checked) return "warehouse";
            if (radioButtonSale.Checked) return "sale";
            if (radioButtonCustomer.Checked) return "customer";
            return string.Empty;
        }
        
        private string GetSelectedRoleid()
        {
            if (radioButtonAdmin.Checked) return "admin";
            if (radioButtonWarehouse.Checked) return "warehouse";
            if (radioButtonSale.Checked) return "sale";
            if (radioButtonCustomer.Checked) return "customer";

            MessageBox.Show("No role selected."); // Thông báo nếu không có vai trò nào được chọn
            return string.Empty;
        }
        private int GetRoleId(string roleName)
        {
            int roleId = -1; // Giá trị mặc định nếu không tìm thấy
            string query = "SELECT id FROM [Role] WHERE roleName = @RoleName";

            // Ghi nhận giá trị roleName
            Console.WriteLine($"Searching for role: '{roleName}'");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoleName", roleName);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    roleId = Convert.ToInt32(result);
                }
            }

            // Kiểm tra xem roleId có hợp lệ không
            if (roleId == -1)
            {
                // Thêm thông báo lỗi nếu không tìm thấy vai trò
                throw new ArgumentException($"Invalid role: '{roleName}'");
            }

            return roleId;
        }
        private bool IsValidRole(string roleName)
        {
            
            var validRoles = new List<string> { "Admin", "Warehouse", "Sale", "Employee" };
            return validRoles.Contains(roleName);
        }
    }
}
