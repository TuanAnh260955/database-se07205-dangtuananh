using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static SaleManagementWinform.Form1;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SaleManagementWinform
{
    public partial class Oder : Form
    {
        public static string SQLConnection = "Server=WHALE;Database=SALE_MANGEMENT;Trusted_Connection=True;";
        public Oder()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Vô hiệu hóa nút tối đa hóa/khôi phục
            this.MaximizeBox = false;

            // Tùy chọn: Đặt kiểu đường viền cố định để ngăn chặn việc thay đổi kích thước
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Load += new System.EventHandler(this.Oder_Load);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SQLConnection))
                {
                    string query = "SELECT TOP 6 code, name, price, quantity, ImagePuth FROM Product";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable productTable = new DataTable();
                    adapter.Fill(productTable);

                    if (productTable.Rows.Count > 0)
                    {
                        AssignPictureBox(productTable.Rows[0], pictureBox1);
                        AssignPictureBox(productTable.Rows[1], pictureBox2);
                        AssignPictureBox(productTable.Rows[2], pictureBox3);
                        AssignPictureBox(productTable.Rows[3], pictureBox4);
                        AssignPictureBox(productTable.Rows[4], pictureBox5);
                        AssignPictureBox(productTable.Rows[5], pictureBox6);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}");
            }
        }
        string basePath = @"D:\Image\"; // Thư mục chứa hình ảnh
        private void AssignPictureBox(DataRow product, PictureBox pictureBox)
        {
            string imagePath = product["ImagePuth"].ToString();

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox.Image = Image.FromFile(@"D:\Image\default.png"); // Đặt ảnh mặc định
            }

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.Tag = product; // Lưu thông tin sản phẩm trong `Tag`
            pictureBox.Click += PictureBox_Click;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                if (pictureBox.Tag is DataRow product)
                {
                    txtCode.Text = product["code"].ToString();
                    txtName.Text = product["name"].ToString();
                    txtPrice.Text = product["price"].ToString();
                    txtQuantity.Text = "1";
                }
                else
                {
                    MessageBox.Show("No product information available.");
                }
            }
            else
            {
                MessageBox.Show("Invalid click event.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtName.Text) ||
        string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            try
            {
                string productCode = txtCode.Text;
                string productName = txtName.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text) * quantity;

                PlaceOrder(productCode, productName, price, quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}");
            }
        }
        private void PlaceOrder(string productCode, string productName, decimal totalPrice, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(SQLConnection))
            {
                try
                {
                    string query = "INSERT INTO Orders (ProductCode, ProductName, Price, Quantity, OrderDate) " +
                                   "VALUES (@ProductCode, @ProductName, @Price, @Quantity, GETDATE())";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductCode", productCode);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", totalPrice);
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
        private void Oder_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProduct()
        {
            try
            {
                // Mở kết nối SQL
                using (SqlConnection connection = new SqlConnection(SQLConnection))
                {
                    connection.Open(); // Kết nối đến cơ sở dữ liệu
                    string query = "SELECT TOP 6 code, name, price, quantity, ImagePath FROM Product"; // Lấy 6 sản phẩm đầu tiên
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable productTable = new DataTable();
                    adapter.Fill(productTable);

                    // Nếu có dữ liệu, ánh xạ vào PictureBox
                    if (productTable.Rows.Count > 0)
                    {
                        AssignPictureBox(productTable.Rows[0], pictureBox1);
                        AssignPictureBox(productTable.Rows[1], pictureBox2);
                        AssignPictureBox(productTable.Rows[2], pictureBox3);
                        AssignPictureBox(productTable.Rows[3], pictureBox4);
                        AssignPictureBox(productTable.Rows[4], pictureBox5);
                        AssignPictureBox(productTable.Rows[5], pictureBox6);
                    }
                    else
                    {
                        MessageBox.Show("No products found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

    }
}
