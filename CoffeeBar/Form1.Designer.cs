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
            this.numericUpDownDeposit = new System.Windows.Forms.NumericUpDown();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.textBoxLastItem = new System.Windows.Forms.TextBox();
            this.labelLastItem = new System.Windows.Forms.Label();
            this.groupBoxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposit)).BeginInit();
            this.groupBoxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxLastItem);
            this.groupBoxCustomerInfo.Controls.Add(this.labelLastItem);
            this.groupBoxCustomerInfo.Controls.Add(this.numericUpDownDeposit);
            this.groupBoxCustomerInfo.Controls.Add(this.labelDeposit);
            this.groupBoxCustomerInfo.Controls.Add(this.buttonDeposit);
            this.groupBoxCustomerInfo.Controls.Add(this.comboBoxCustomerName);
            this.groupBoxCustomerInfo.Controls.Add(this.textBoxBalance);
            this.groupBoxCustomerInfo.Controls.Add(this.labelBalance);
            this.groupBoxCustomerInfo.Controls.Add(this.labelCustomer);
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(1, 12);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(310, 297);
            this.groupBoxCustomerInfo.TabIndex = 0;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // numericUpDownDeposit
            // 
            this.numericUpDownDeposit.DecimalPlaces = 2;
            this.numericUpDownDeposit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDeposit.Location = new System.Drawing.Point(6, 193);
            this.numericUpDownDeposit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDeposit.Name = "numericUpDownDeposit";
            this.numericUpDownDeposit.Size = new System.Drawing.Size(49, 23);
            this.numericUpDownDeposit.TabIndex = 8;
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(6, 175);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(47, 15);
            this.labelDeposit.TabIndex = 7;
            this.labelDeposit.Text = "Deposit";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(6, 222);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit.TabIndex = 6;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(6, 43);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(298, 23);
            this.comboBoxCustomerName.TabIndex = 4;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(6, 99);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(100, 23);
            this.textBoxBalance.TabIndex = 3;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(6, 75);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(48, 15);
            this.labelBalance.TabIndex = 2;
            this.labelBalance.Text = "Balance";
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
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.comboBoxItem);
            this.groupBoxItems.Controls.Add(this.buttonPurchase);
            this.groupBoxItems.Controls.Add(this.textBoxCost);
            this.groupBoxItems.Controls.Add(this.labelCost);
            this.groupBoxItems.Controls.Add(this.labelItem);
            this.groupBoxItems.Location = new System.Drawing.Point(326, 12);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(310, 217);
            this.groupBoxItems.TabIndex = 1;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
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
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(6, 131);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonPurchase.TabIndex = 4;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(6, 95);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
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
            // textBoxLastItem
            // 
            this.textBoxLastItem.Location = new System.Drawing.Point(5, 149);
            this.textBoxLastItem.Name = "textBoxLastItem";
            this.textBoxLastItem.ReadOnly = true;
            this.textBoxLastItem.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastItem.TabIndex = 10;
            // 
            // labelLastItem
            // 
            this.labelLastItem.AutoSize = true;
            this.labelLastItem.Location = new System.Drawing.Point(5, 125);
            this.labelLastItem.Name = "labelLastItem";
            this.labelLastItem.Size = new System.Drawing.Size(55, 15);
            this.labelLastItem.TabIndex = 9;
            this.labelLastItem.Text = "Last Item";
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposit)).EndInit();
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
        private Label labelDeposit;
        private Button buttonDeposit;
        private NumericUpDown numericUpDownDeposit;
        private TextBox textBoxLastItem;
        private Label labelLastItem;
    }
}