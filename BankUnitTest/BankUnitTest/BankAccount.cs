using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest
{
    public class BankAccount
    {
        string _customerName;
        double _balance;

        public BankAccount(string customerName, double balance)
        {
            this._balance = balance;
            this._customerName = customerName;
        }

        public double Blanace { get { return _balance; } }

        public void Debit(double amount)
        {
            if (_balance == 0)
            {
                throw new Exception("Balance is 0");
            }
            if (amount <= 0 || amount > _balance)
            {
                throw new Exception("Amount is <= 0 or > balance");
            }
            _balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount is <= 0");
            }
            _balance += amount;
        }
    }
}

