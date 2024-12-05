using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            // Đặt biểu mẫu bắt đầu ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // Vô hiệu hóa nút tối đa hóa/khôi phục
            this.MaximizeBox = false;

            // Tùy chọn: Đặt kiểu đường viền cố định để ngăn chặn việc thay đổi kích thước
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PurchaseHistory purchaseHistory = new PurchaseHistory();
            purchaseHistory.Show();
            this.Hide();
        }

    }
}
