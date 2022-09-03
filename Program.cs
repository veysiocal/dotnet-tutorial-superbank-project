// using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Veysi", 1000);
            Console.WriteLine( $" account number: {account.Number} , account owner: {account.Owner}, account balance: {account.Balance} ");
            
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine("Your new balance is: " + account.Balance);


            Console.WriteLine(account.GetAccountHistory());


            // Test that the initial balacnes must be positive 
            try
            {
                var invalidAccount = new BankAccount("incalid", -55);
            }
            catch (ArgumentOutOfRangeException e) 
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
             // This catch does not stop program, just console error and continue.

            account.MakeWithdrawal(10, DateTime.Now, "Xbox Game");
            Console.WriteLine("Your new balance after xbox: " + account.Balance);

            // Test for negative balance:
            try
            {
                account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

                Console.WriteLine("geldi mi??");


        }
    }
}