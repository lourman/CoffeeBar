namespace CoffeeBar
{
    public partial class Form1 : Form
    {
        //Storage
        Person alex;

        Person currentPerson;

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

            alex = new Person("Dave", 12.0m);
            comboBoxCustomerName.Items.Add(alex.GetName());
            comboBoxCustomerName.SelectedIndex = 0;
            currentPerson = alex;
            ShowCurrentPerson();
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
                    currentPerson = alex;
                    break;
                default:
                    currentPerson = alex;
                    break;
            }
            ShowCurrentPerson();
        }

        public void ShowCurrentPerson()
        {
            // textBoxBalance.Text = currentPerson.GetBalance().ToString;
        }
    }
}