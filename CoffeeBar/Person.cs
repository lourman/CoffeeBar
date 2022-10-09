using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBar
{
    internal class Person
    {
        // attributes
        string name;
        decimal balance;
        Item lastItem;

        /// <summary>
        /// Property to return the last purchased item
        /// </summary>
        public Item LastPurchase
        {
            get
            {
                return lastItem;
            }
        }

        /// <summary>
        /// Constructor with only the name of the customer.
        /// Default balance is 10 GBP and the last item is set to null
        /// </summary>
        /// <param name="Name">Customer name</param>
        public Person(string Name)
        {
            this.name = Name;
            this.balance = 10.0m;
            this.lastItem = null;
        }

        /// <summary>
        /// Constructor with only the name of the customer and their initial deposit.
        /// Default last item is set to null
        /// </summary>
        /// <param name="Name">Customer name</param>
        /// <param name="Balance">Customer account balance in GBP</param>
        public Person(string Name, decimal Balance)
        {
            this.name = Name;
            this.balance = Balance;
            this.lastItem = null;
        }

        /// <summary>
        /// Method to return the name of the account holder
        /// </summary>
        /// <returns>The name</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Method to return the balance of the account holder
        /// </summary>
        /// <returns>The balance</returns>
        public Decimal GetBalance()
        {
            return balance;
        }

        /// <summary>
        /// Method to deposit money for a person
        /// </summary>
        /// <param name="Amount">The ammount of money to deposit</param>
        public void Deposit(decimal Amount)
        {
            this.balance += Amount;
        }

        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool DecBalance(decimal amount)
        {
            bool result = false;
            
            if (this.balance >= amount)
            {
                result = true;
                this.balance -= amount;
            }

            return result;
        }
    }
}
