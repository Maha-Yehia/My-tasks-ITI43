namespace task2_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine( math.add(5, 7));
            Console.WriteLine(math.subtract(5, 7));
            Console.WriteLine(math.multiply(5, 7));
            Console.WriteLine(Math.Round(math.divide(5, 7),3));
        }

      static  class math
        {

            public static double add (double x, double y)
            {
                return x + y;   
            }
            public static double subtract(double x, double y)
            {
                return x - y;
            }
            public static double multiply (double x, double y)
            {
                return x * y;
            }
            public static double divide(double x, double y)
            {
                if (y != 0) { return x / y; }
                else return 0; 
            }



        }





    }
}