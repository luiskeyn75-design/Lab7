namespace Lab7Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<double, double> discountCalculator = (price) => price * 0.95;
            discountCalculator += (price) => price * 0.90;
            discountCalculator += (price) => price - 100;

            double finalprice = 1000;
            var delegates = discountCalculator.GetInvocationList();
            foreach(var del in delegates)
            {
                var method = (Func<double, double>)del;
                finalprice = method(finalprice);
            }
            Console.WriteLine(finalprice);
        }
    }
}