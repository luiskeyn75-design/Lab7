namespace Lab7Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Action> actions = new List<Action>();
            for(int i = 1; i <= 5; i++)
            {
                int temp = i;
                actions.Add(() => Console.WriteLine(temp));
            }

            foreach(var action in actions)
            {
                action();
            }
        }
    }
}