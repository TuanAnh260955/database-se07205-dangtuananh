namespace SaleManagementWinform
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_CustomerOders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.Yellow;
            this.btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.Location = new System.Drawing.Point(686, 217);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(155, 44);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.Text = "Product Management";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.Lime;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(686, 71);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(155, 46);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "Customer Management";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.Location = new System.Drawing.Point(686, 123);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(155, 42);
            this.btn_Employee.TabIndex = 0;
            this.btn_Employee.Text = "Employee Management";
            this.btn_Employee.UseVisualStyleBackColor = false;
            this.btn_Employee.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.BackColor = System.Drawing.Color.Green;
            this.btn_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchase.Location = new System.Drawing.Point(686, 171);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(155, 40);
            this.btn_Purchase.TabIndex = 0;
            this.btn_Purchase.Text = "Purchase History";
            this.btn_Purchase.UseVisualStyleBackColor = false;
            this.btn_Purchase.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orders.Location = new System.Drawing.Point(686, 12);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(155, 53);
            this.btn_Orders.TabIndex = 0;
            this.btn_Orders.Text = "Orders";
            this.btn_Orders.UseVisualStyleBackColor = false;
            this.btn_Orders.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Logout.Location = new System.Drawing.Point(686, 322);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(155, 55);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_CustomerOders
            // 
            this.btn_CustomerOders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CustomerOders.Location = new System.Drawing.Point(686, 267);
            this.btn_CustomerOders.Name = "btn_CustomerOders";
            this.btn_CustomerOders.Size = new System.Drawing.Size(155, 49);
            this.btn_CustomerOders.TabIndex = 3;
            this.btn_CustomerOders.Text = "Customer Oders";
            this.btn_CustomerOders.UseVisualStyleBackColor = false;
            this.btn_CustomerOders.Click += new System.EventHandler(this.btn_CustomerOders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaleManagementWinform.Properties.Resources.Premium_Vector___Customer_with_online_shopping_set_icons;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 375);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 386);
            this.Controls.Add(this.btn_CustomerOders);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Orders);
            this.Controls.Add(this.btn_Purchase);
            this.Controls.Add(this.btn_Employee);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Product);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_CustomerOders;
    }
}