namespace Lab7Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankTerminal terminal = new BankTerminal();
            terminal.OnMoneyWithdraw += (money) => Console.WriteLine($"Знято:{money} ");
            terminal.MoneyWithdraw(150);
          
        }
    }

    public class BankTerminal
    {
        public event Action<int> OnMoneyWithdraw;
        public void MoneyWithdraw(int amount)
        {
            OnMoneyWithdraw?.Invoke(amount);

        }
        
    }
}