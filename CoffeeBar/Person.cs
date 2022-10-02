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

        //constructor
        public Person(string Name)
        {
            this.name = Name;
            this.balance = 10.0m;
        }

        public Person(string Name, decimal Balance)
        {
            this.name = Name;
            this.balance = Balance;
        }

        // methods
        public string GetName()
        {
            return this.name;
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
            //code to decrement the balance...

            return result;
        }
    }
}
