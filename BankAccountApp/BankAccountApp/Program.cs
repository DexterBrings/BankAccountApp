namespace BankAccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte legen Sie ihr Konto an.");
            Console.WriteLine("Geben Sie die Kontonummer ein:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie nun Ihren Namen ein:");
            string name = Console.ReadLine();

            Console.WriteLine("Geben Sie zuletzt das Startguthaben ein:");
            float initialBalance = float.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(
                number,
                name,
                initialBalance
                );

            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1. Einzahlung vornehmen");
                Console.WriteLine("2. Auszahlung vornehmen");
                Console.WriteLine("3. Kontostand anzeigen");
                Console.WriteLine("4. Beenden");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    Console.WriteLine("Geben Sie den Betrag zur Einzahlung ein:");
                    float depositAmount = float.Parse(Console.ReadLine());
                    account.MakeDeposit(depositAmount);
                    account.PrintBalance();
                }
                else if(input == "2")
                {
                    Console.WriteLine("Geben Sie den Betrag zur Auszahlung ein:");
                    float payoutAmount = float.Parse(Console.ReadLine());
                    account.MakeWithdrawal(payoutAmount);
                    account.PrintBalance();
                } 
                else if (input == "3")
                {
                    account.PrintBalance();
                } 
                else if (input == "4")
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie einen anderen Punkt.");
                }
            }

        }
    }
}
