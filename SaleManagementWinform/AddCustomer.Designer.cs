namespace SaleManagementWinform
{
    partial class AddCustomer
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
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_phonenumber = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(348, 233);
            this.txb_address.Multiline = true;
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(245, 31);
            this.txb_address.TabIndex = 13;
            // 
            // txb_phonenumber
            // 
            this.txb_phonenumber.Location = new System.Drawing.Point(348, 180);
            this.txb_phonenumber.Multiline = true;
            this.txb_phonenumber.Name = "txb_phonenumber";
            this.txb_phonenumber.Size = new System.Drawing.Size(245, 31);
            this.txb_phonenumber.TabIndex = 14;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(348, 127);
            this.txb_name.Multiline = true;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(245, 31);
            this.txb_name.TabIndex = 15;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(348, 79);
            this.txb_code.Multiline = true;
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(245, 31);
            this.txb_code.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(348, 279);
            this.txb_email.Multiline = true;
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(245, 31);
            this.txb_email.TabIndex = 13;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_phonenumber);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_phonenumber;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_email;
    }
}