namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                int a, i;
                double factorial = 1;

                Console.Write("Enter a number: ");
                a = int.Parse(Console.ReadLine());

                for (i = 1; i <= a; ++i)
                {
                    factorial *=  i;
                }

                Console.WriteLine("Factorial of {0} = {1}", a, factorial);
                Main(args);
             
        }
     }
 }

