namespace task2_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[4] { 5,6,7,8 };
            Demo.SumArr1(myArr);
            Console.WriteLine($"at the beginning: {myArr.GetHashCode()}");
            Console.WriteLine($"after passing by value: {myArr.GetHashCode()}");
            Demo.SumArr2(ref myArr);
            Console.WriteLine($"after passing by reference: {myArr.GetHashCode()}");
        }


        class Demo
        {
            public static void SumArr1(int[] myArr)
            {
                myArr = new int[4] { 1, 2, 3, 4 };
                Console.WriteLine($"Inside value function: {myArr.GetHashCode()}");
            }

            public static void SumArr2(ref int[] myArr)
            {
                myArr = new int[4] { 1, 2, 3, 4 };
                Console.WriteLine($"Inside ref function: {myArr.GetHashCode()}");
            }

        }
    }




}
