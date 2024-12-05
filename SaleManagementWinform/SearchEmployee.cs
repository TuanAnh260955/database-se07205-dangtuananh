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
    public partial class SearchEmployee : Form
    {
        public static string connectionString = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public SearchEmployee()
        {
            InitializeComponent();
        }
        private void SearchEmployeeByCode(string code)
        {
            string query = "SELECT * FROM Employee WHERE Code = @Code";

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
                                    string employeeCode = reader["code"].ToString();
                                    string EmployeeName = reader["name"].ToString();
                                    string position = reader["position"].ToString();
                                    string roleid = reader["roleid"].ToString();
                                    string username = reader["username"].ToString();
                                    string password = reader["password"].ToString();

                                    MessageBox.Show($"Code: {employeeCode}, Name: {EmployeeName},   Position: {position}, Roleid: {roleid}, Username: {username}, password: {password}");
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
            string code = txbCode.Text.Trim(); // TextBox cho mã khách hàng
            SearchEmployeeByCode(code);
        }
    }
}
