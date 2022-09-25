namespace CoffeeBar
{
    public partial class Form1 : Form
    {
        //Storage
        string[] Customers;
        decimal[] Balances;

        string[] Items;
        decimal[] Prices;

        const int NUM_CUSTOMERS = 3;
        const int NUM_PRODUCTS = 2;

        int current_customer_index;
        int current_product_index;

        /// <summary>
        /// Form Constructor 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads data and initialises the form controls
        /// </summary>
        /// <param name="sender">Form Control</param>
        /// <param name="e">Arguments</param>
        private void Form1_Load(object sender, EventArgs e)
        {

            Customers = new string[NUM_CUSTOMERS];
            Balances = new decimal[NUM_CUSTOMERS];

            Items = new string[NUM_PRODUCTS];
            Prices = new decimal[NUM_PRODUCTS];
#if DEBUG
            Customers[0] = "Alex";
            Customers[1] = "Hannan";
            Customers[2] = "Gordon";

            Balances[0] = 12.00m;
            Balances[1] = 20.00m;
            Balances[2] = 5.00m;
#endif
            if (Customers[0] is not null)
            {
                current_customer_index = 0;

                //put items into drop downs
                for (int customerLoop = 0; customerLoop < NUM_CUSTOMERS; customerLoop++)
                {
                    comboBoxCustomerName.Items.Add(Customers[customerLoop]);
                }
                comboBoxCustomerName.SelectedIndex = 0;
            }
            
            comboBoxItem.Items.Add("Tea");
            comboBoxItem.Items.Add("Coffee");
            comboBoxItem.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to populate customer information on the UI
        /// </summary>
        private void ShowCurrentCustomer()
        {
            textBoxBalance.Text = Balances[current_customer_index].ToString();
        }

        /// <summary>
        /// Method to populate item information on the UI
        /// </summary>
        private void ShowCurrentProduct()
        {
            if (current_product_index == 0)
            {
                textBoxCost.Text = "0.50";
            }
            else
            {
                textBoxCost.Text = "0.75";
            }

        }

        /// <summary>
        /// Update the customer when the user selects a different customer
        /// </summary>
        /// <param name="sender">Customer Combobox</param>
        /// <param name="e">Arguments</param>
        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_customer_index = comboBoxCustomerName.SelectedIndex;
            ShowCurrentCustomer();
        }

        /// <summary>
        /// Update the item when the user selects a different item in the shop
        /// </summary>
        /// <param name="sender">Item Combobox</param>
        /// <param name="e">Arguments</param>
        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_product_index = comboBoxItem.SelectedIndex;
            ShowCurrentProduct();

            Balances[0] += 1m;
        }

        /// <summary>
        /// Purchase an item for a customer and update their record accordingly
        /// </summary>
        /// <param name="sender">Purchase Button</param>
        /// <param name="e">Arguments</param>
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            decimal item_price;
            bool customer_in_credit = false;

            if (current_product_index == 0)
                item_price = 0.50m;
            else
                item_price = 0.75m;

            if (Balances[current_customer_index] - item_price >= 0.0m)
            {
                customer_in_credit = true;
                Balances[current_customer_index] -= item_price;
            }


            if (customer_in_credit)
            {
                ShowCurrentCustomer();
            }
            else
            {
                //error
                MessageBox.Show("Insufficient Balance", "Error");
            }
        }
    }
}