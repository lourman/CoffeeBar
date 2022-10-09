namespace CoffeeBar
{
    public partial class Form1 : Form
    {
        //Storage
        Person customer1;
        Person customer2;
        Person customer3;

        Person currentPerson;

        Item item1;
        Item item2;

        Item currentItem;

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

            customer1 = new Person("Dave", 12.0m);
            customer2 = new Person("Sebastian", 20.0m);
            customer3 = new Person("Gordon", 5.0m);
            comboBoxCustomerName.Items.Add(customer1.GetName());
            comboBoxCustomerName.Items.Add(customer2.GetName());
            comboBoxCustomerName.Items.Add(customer3.GetName());
            comboBoxCustomerName.SelectedIndex = 0;
            currentPerson = customer1;
            ShowCurrentPerson();

            item1 = new Item("Coffee", 0.50m);
            item2 = new Item("Tea", 0.30m);
            
            comboBoxItem.Items.Add(item1.Name);
            comboBoxItem.Items.Add(item2.Name);

            comboBoxItem.SelectedIndex = 0;

            currentItem = item1;

            ShowCurrentItem();
        }


        /// <summary>
        /// Update the customer when the user selects a different customer
        /// </summary>
        /// <param name="sender">Customer Combobox</param>
        /// <param name="e">Arguments</param>
        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCustomerName.SelectedIndex)
            {
                case 0:
                    currentPerson = customer1;
                    break;
                case 1:
                    currentPerson = customer2;
                    break;
                case 2:
                    currentPerson = customer3;
                    break;
                default:
                    currentPerson = customer1;
                    break;
            }
            ShowCurrentPerson();
        }

        /// <summary>
        /// Display the balance of the selected person account
        /// </summary>
        public void ShowCurrentPerson()
        {
            textBoxBalance.Text = currentPerson.GetBalance().ToString();
        }

        /// <summary>
        /// Display the price of the selected item
        /// </summary>
        public void ShowCurrentItem()
        {
            textBoxCost.Text = currentItem.Price.ToString();
        }

        /// <summary>
        /// Set the current item to the selected item in the drop list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxItem.SelectedIndex)
            {
                case 0:
                    currentItem = item1;
                    break;
                case 1:
                    currentItem = item2;
                    break;
                default:
                    currentItem = item1;
                    break;
            }
            ShowCurrentItem();
        }

        /// <summary>
        /// Deposit money and add to the account of the selected person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            currentPerson.Deposit(numericUpDownDeposit.Value);
            ShowCurrentPerson();
        }

        /// <summary>
        /// Button to make a purchase of a selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            if (!currentPerson.DecBalance(currentItem.Price))
            {
                MessageBox.Show("insufficient funds.");
            }
            ShowCurrentPerson();
        }
    }
}