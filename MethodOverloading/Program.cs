namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!" + Environment.NewLine);

            int sum = Add(2, 6);

            double decimalSum = Add(3.85, 2.1);

            string dollarsSum = Add(3, 4, true);

            Console.WriteLine
                ($"Sum: {sum}" 
                    + Environment.NewLine + Environment.NewLine
                + $"Decimal Sum: {decimalSum}"
                    + Environment.NewLine + Environment.NewLine);

            Console.WriteLine(dollarsSum);
            
        }

        public static int Add(int a ,  int b) 
        {
            return a + b;
        }

        public static double Add(double c, double d)
        {
            return c + d;
        }
        public static string Add(int e, int f, bool isDollars)
        {
            int sum = e + f;

            //return (isDollars == true) ? sum + " dollars" : $"{sum}";

            if (isDollars == true)
            {
                if (sum == 1)
                {
                    return sum + " dollar";
                }
                else
                {
                    return sum + " dollars";
                }
            }
            else
            {
                return $"{sum}";
            }

        }



    }
}
