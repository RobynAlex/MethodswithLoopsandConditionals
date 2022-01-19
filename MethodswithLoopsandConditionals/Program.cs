using System;

namespace MethodswithLoopsandConditionals
{
    class Program
    {
        public static void Print1000s()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void TwoEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Those numbers are equal!");
            }
            else
            {
                Console.WriteLine("Those numbers are not equal, try again.");
            }
        }
        public static void OddEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
        public static void PosOrNeg(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            }
            else
            {
                Console.WriteLine($"{num} is negative.");
            }
        }
        public static void VotingAge()
        {
            Console.WriteLine("Please Enter Your Age:");
            bool oldEnough = int.TryParse(Console.ReadLine(), out int result);

            if (result < 18)
            {
                Console.WriteLine("Not now, sorry.");
            }
            else
            {
                Console.WriteLine("You can vote, Go Vote!");
            }
        }
        public static void InRange()
        {
            Console.WriteLine("Enter an Integer");

            var userResponse = int.TryParse(Console.ReadLine(), out int result);

            if(result >= -10 && result <= 10)
            {
                Console.WriteLine($"{result} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{result} is NOT between -10 and 10");
            }   
        }
        public static void MulTable()
        {
            Console.WriteLine("Enter an Integer");

            var userResponse = int.TryParse(Console.ReadLine(), out int result);

            for(int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {result} = {x * result}");
            }
        }
        static void Main(string[] args)
        {
            //Print1000s();
            //PrintThrees();
            //TwoEqual(4,3);
            //TwoEqual(7, 7);
            //OddEven(3);
            //OddEven(12);
            //PosOrNeg(23);
            //PosOrNeg(-44);
            //VotingAge();
            //InRange();
            //MulTable();
        }
    }
}
