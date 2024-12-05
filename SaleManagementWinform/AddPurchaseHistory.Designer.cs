namespace SaleManagementWinform
{
    partial class AddPurchaseHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_PurchaseID = new System.Windows.Forms.TextBox();
            this.txb_CustomerCode = new System.Windows.Forms.TextBox();
            this.txb_Code = new System.Windows.Forms.TextBox();
            this.txb_PurchaseDate = new System.Windows.Forms.TextBox();
            this.txb_Quantity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PurchaseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustomerCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PurchaseDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_PurchaseID
            // 
            this.txb_PurchaseID.Location = new System.Drawing.Point(188, 46);
            this.txb_PurchaseID.Multiline = true;
            this.txb_PurchaseID.Name = "txb_PurchaseID";
            this.txb_PurchaseID.Size = new System.Drawing.Size(169, 29);
            this.txb_PurchaseID.TabIndex = 6;
            // 
            // txb_CustomerCode
            // 
            this.txb_CustomerCode.Location = new System.Drawing.Point(188, 94);
            this.txb_CustomerCode.Multiline = true;
            this.txb_CustomerCode.Name = "txb_CustomerCode";
            this.txb_CustomerCode.Size = new System.Drawing.Size(169, 29);
            this.txb_CustomerCode.TabIndex = 6;
            // 
            // txb_Code
            // 
            this.txb_Code.Location = new System.Drawing.Point(188, 146);
            this.txb_Code.Multiline = true;
            this.txb_Code.Name = "txb_Code";
            this.txb_Code.Size = new System.Drawing.Size(169, 29);
            this.txb_Code.TabIndex = 6;
            // 
            // txb_PurchaseDate
            // 
            this.txb_PurchaseDate.Location = new System.Drawing.Point(188, 189);
            this.txb_PurchaseDate.Multiline = true;
            this.txb_PurchaseDate.Name = "txb_PurchaseDate";
            this.txb_PurchaseDate.Size = new System.Drawing.Size(169, 29);
            this.txb_PurchaseDate.TabIndex = 6;
            // 
            // txb_Quantity
            // 
            this.txb_Quantity.Location = new System.Drawing.Point(188, 240);
            this.txb_Quantity.Multiline = true;
            this.txb_Quantity.Name = "txb_Quantity";
            this.txb_Quantity.Size = new System.Drawing.Size(169, 29);
            this.txb_Quantity.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txb_Quantity);
            this.Controls.Add(this.txb_PurchaseDate);
            this.Controls.Add(this.txb_Code);
            this.Controls.Add(this.txb_CustomerCode);
            this.Controls.Add(this.txb_PurchaseID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPurchaseHistory";
            this.Text = "AddPurchaseHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_PurchaseID;
        private System.Windows.Forms.TextBox txb_CustomerCode;
        private System.Windows.Forms.TextBox txb_Code;
        private System.Windows.Forms.TextBox txb_PurchaseDate;
        private System.Windows.Forms.TextBox txb_Quantity;
        private System.Windows.Forms.Button button2;
    }
}