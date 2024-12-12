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
    
    public partial class PurchaseHistory : Form
    {
        public static string ConnectionString
    = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        private string connectionString;

        public PurchaseHistory()
        {
            InitializeComponent();
            // Tối đa hóa biểu mẫu và giữ nó ở trên Thanh tác vụ
            this.WindowState = FormWindowState.Maximized;

            // Đặt kiểu đường viền biểu mẫu để đảm bảo nó có giao diện cửa sổ chuẩn
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Tùy chọn, hãy đặt StartPosition thành CenterScreen nếu bạn muốn tải ở giữa
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_purchasehistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_purchasehistory.CellClick += new DataGridViewCellEventHandler(this.dataGridViewPurchase_CellClick); this.LoadData();
        }
        private void LoadData()
        {
            // SQL query to fetch data with JOIN
            string query = @"
        SELECT 
            ph.PurchaseID, 
            ph.CustomerCode, 
            ph.Code AS ProductCode, 
            p.Name AS ProductName, 
            ph.PurchaseDate, 
            ph.Quantity, 
            p.Price, 
            p.Active AS ProductActiveStatus
        FROM 
            [SALE_MANGEMENT].[dbo].[PurchaseHistory] ph
        JOIN 
            [SALE_MANGEMENT].[dbo].[Product] p ON ph.Code = p.Code";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with query results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgv_purchasehistory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddPurchaseHistory addPurchaseHistory = new AddPurchaseHistory();
            addPurchaseHistory.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePurchaseHistory form = new UpdatePurchaseHistory(selectedPurchaseID, selectedCustomerCode, selectedProductCode, selectedPurchaseDate, selectedQuantity);;
            form.ShowDialog();
            this.Hide();
        }
        private string selectedPurchaseID;
        private string selectedCustomerCode;
        private string selectedProductCode;
        private DateTime selectedPurchaseDate;
        private int selectedQuantity;
        private void dataGridViewPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_purchasehistory.Rows[e.RowIndex];

                selectedPurchaseID = selectedRow.Cells["PurchaseID"].Value.ToString();
                selectedCustomerCode = selectedRow.Cells["CustomerCode"].Value.ToString();
                selectedProductCode = selectedRow.Cells["Code"].Value.ToString();
                selectedPurchaseDate = Convert.ToDateTime(selectedRow.Cells["PurchaseDate"].Value);
                selectedQuantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());

                UpdatePurchaseHistory updatePurchase = new UpdatePurchaseHistory(selectedPurchaseID, selectedCustomerCode, selectedProductCode, selectedPurchaseDate, selectedQuantity);
                updatePurchase.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchPurchaseHistory searchForm = new SearchPurchaseHistory();
            searchForm.Show();
        }
    }
}
