using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var elijahsAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            elijahsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Your balance is now ${elijahsAccount.GetBalance()}.");
        }
    }
}
