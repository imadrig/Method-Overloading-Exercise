namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a ,  int b) 
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            return (isTrue == true) ? (a + b) + "dollars" : "No Dollars";
        }

    }
}
