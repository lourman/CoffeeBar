namespace CoffeeBar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.groupBoxCustomerInfo.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Controls.Add(this.comboBoxCustomerName);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxBalance);
            this.groupBoxCustomerInfo.Controls.Add(this.labelBalance);
            this.groupBoxCustomerInfo.Controls.Add(this.labelCustomer);
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(1, 12);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(310, 210);
            this.groupBoxCustomerInfo.TabIndex = 0;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(6, 19);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(94, 15);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Customer Name";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(6, 95);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 23);
            this.textBoxBalance.TabIndex = 3;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(6, 77);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(48, 15);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "Balance";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.comboBoxItem);
            this.groupBoxItems.Controls.Add(this.buttonPurchase);
            this.groupBoxItems.Controls.Add(this.textBoxCost);
            this.groupBoxItems.Controls.Add(this.labelCost);
            this.groupBoxItems.Controls.Add(this.labelItem);
            this.groupBoxItems.Location = new System.Drawing.Point(326, 12);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(310, 210);
            this.groupBoxItems.TabIndex = 1;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(6, 95);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 23);
            this.textBoxCost.TabIndex = 3;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(6, 77);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(31, 15);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Cost";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(6, 19);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(31, 15);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "Item";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(17, 151);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonPurchase.TabIndex = 4;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(6, 37);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(298, 23);
            this.comboBoxCustomerName.TabIndex = 4;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(6, 37);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(298, 23);
            this.comboBoxItem.TabIndex = 5;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxItems);
            this.Controls.Add(this.groupBoxCustomerInfo);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxCustomerInfo;
        private ComboBox comboBoxCustomerName;
        private TextBox textBoxBalance;
        private Label labelBalance;
        private Label labelCustomer;
        private GroupBox groupBoxItems;
        private ComboBox comboBoxItem;
        private Button buttonPurchase;
        private TextBox textBoxCost;
        private Label labelCost;
        private Label labelItem;
    }
}