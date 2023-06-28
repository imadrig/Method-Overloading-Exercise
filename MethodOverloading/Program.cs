namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!" + Environment.NewLine);

            int a = 1;
            int b = 6;
            int sum = Add(a, b);

            double c = 3.85;
            double d = 2.1;
            double decimalSum = Add(c, d);

            string dollarsSum = Add(3, 4, true);

            
        }

        public static int Add(int a ,  int b) 
        {
            return a + b;
        }

        public static double Add(double c, double d)
        {
            return c + d;
        }
        public static string Add(int e, int f, bool isCheck)
        {
            int sum = e + f;
            return (isCheck == true) ? $"{sum} + dollars" : $"{sum}";
        }



    }
}
