using System;
namespace WellsAdd
{
    public static class AddProgram
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter two numbers to be added (x + y)");
                try
                {
                    int.TryParse(Console.ReadLine(), out int x);

                    int.TryParse(Console.ReadLine(), out int y);

                    int result = Add(x, y);
                    Console.WriteLine(result);

                    //Console.WriteLine("Output using x + y = " + (x + y));
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("System threw an ArithmeticException due to the range of the numbers");
                }
                Console.Read();
            }
        }

        public static int Add(int num1, int num2)
        {
            int sum, cnt;
            if (num1 > num2)
            {
                cnt = num2;
                sum = num1;
            }
            else
            {
                cnt = num1;
                sum = num2;
            }

            for (int i = 0; i < cnt; i++)
            {
                sum = sum + 1;
            }

            return sum;
        }
    }
}
