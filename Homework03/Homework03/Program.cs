namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                int n, i;
                double factorial = 1;

                Console.Write("Enter a number: ");
                n = int.Parse(Console.ReadLine());

                for (i = 1; i <= n; ++i)
                {
                    factorial *=  i;
                }

                Console.WriteLine("Factorial of {0} = {1}", n, factorial);
                Main(args);
             
        }
     }
 }

