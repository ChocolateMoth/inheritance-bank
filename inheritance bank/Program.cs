namespace inheritance_bank
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCredit = 0.0M;
            SavingsAccount sa = new SavingsAccount(1000.25M, 0.1M);

            Console.WriteLine("begining balance is {0:C}", sa.Balance);
            totalCredit= sa.CalInterest();
            Console.WriteLine("total intrest: {0:C}", totalCredit);
            sa.Credit(totalCredit);
            Console.WriteLine("Ending balance is: {0:C}", sa.Balance);
            Console.WriteLine();

            CheckingAccount ca = new CheckingAccount(1000.25M, 5.50M);
            Console.WriteLine("beginning balance is {0:C}", ca.Balance);
            ca.Credit(55.25M);
            ca.Debit(1925.55M);
            Console.WriteLine("ending balance is {0:C}", ca.Balance);
            Console.ReadLine();
        }
    }
}