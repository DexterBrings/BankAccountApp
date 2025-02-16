using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class BankAccount
    {
        public int Number { get; private set; }

        public string Owner { get; private set; }

        public float Balance { get; private set; }


        public BankAccount(int number, string owner, float initialBalance)
        {
            Number = number;
            Owner = owner;
            Balance = initialBalance;
        }

        public void MakeDeposit(float amount)
        {
            Balance += amount;
        }

        public void MakeWithdrawal(float amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Kontostand reicht nicht aus. Bitte anderen Betrag eingeben.");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Der Kontostand vom Konto {Owner} beträgt: {Balance} Euro");
        }

    }
}
