using System.Security.Cryptography.X509Certificates;

namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, first = 0, second = 1, third = 0;
            Console.Write("Enter number : ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write("First{0} Fibonacci numbers {1} {2} ", input, first, second);

            for(int i = 3; i <= input; i++)
            {
                third = first + second;
                Console.Write("{0} ", third);
                first = second;
                second = third;
            }
        }
    }
}
