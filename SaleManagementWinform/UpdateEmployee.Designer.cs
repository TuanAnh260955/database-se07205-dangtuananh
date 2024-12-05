namespace SaleManagementWinform
{
    partial class UpdateEmployee
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_position = new System.Windows.Forms.TextBox();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.radioButtonSale = new System.Windows.Forms.RadioButton();
            this.radioButtonWarehouse = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 53);
            this.button1.TabIndex = 48;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Roleid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Position\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name\r\n";
            // 
            // txb_position
            // 
            this.txb_position.Location = new System.Drawing.Point(281, 178);
            this.txb_position.Multiline = true;
            this.txb_position.Name = "txb_position";
            this.txb_position.Size = new System.Drawing.Size(347, 61);
            this.txb_position.TabIndex = 41;
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Location = new System.Drawing.Point(416, 322);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(85, 20);
            this.radioButtonCustomer.TabIndex = 40;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Customer";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonSale
            // 
            this.radioButtonSale.AutoSize = true;
            this.radioButtonSale.Location = new System.Drawing.Point(274, 322);
            this.radioButtonSale.Name = "radioButtonSale";
            this.radioButtonSale.Size = new System.Drawing.Size(56, 20);
            this.radioButtonSale.TabIndex = 39;
            this.radioButtonSale.TabStop = true;
            this.radioButtonSale.Text = "Sale";
            this.radioButtonSale.UseVisualStyleBackColor = true;
            // 
            // radioButtonWarehouse
            // 
            this.radioButtonWarehouse.AutoSize = true;
            this.radioButtonWarehouse.Location = new System.Drawing.Point(416, 282);
            this.radioButtonWarehouse.Name = "radioButtonWarehouse";
            this.radioButtonWarehouse.Size = new System.Drawing.Size(101, 20);
            this.radioButtonWarehouse.TabIndex = 38;
            this.radioButtonWarehouse.TabStop = true;
            this.radioButtonWarehouse.Text = "WareHouse";
            this.radioButtonWarehouse.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(274, 282);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(66, 20);
            this.radioButtonAdmin.TabIndex = 37;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(281, 461);
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(347, 53);
            this.txb_password.TabIndex = 36;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(281, 369);
            this.txb_username.Multiline = true;
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(347, 53);
            this.txb_username.TabIndex = 35;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(281, 90);
            this.txb_code.Multiline = true;
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(347, 53);
            this.txb_code.TabIndex = 34;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(281, 5);
            this.txb_Name.Multiline = true;
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(347, 53);
            this.txb_Name.TabIndex = 33;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_position);
            this.Controls.Add(this.radioButtonCustomer);
            this.Controls.Add(this.radioButtonSale);
            this.Controls.Add(this.radioButtonWarehouse);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.txb_Name);
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_position;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.RadioButton radioButtonSale;
        private System.Windows.Forms.RadioButton radioButtonWarehouse;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.TextBox txb_Name;
    }
}