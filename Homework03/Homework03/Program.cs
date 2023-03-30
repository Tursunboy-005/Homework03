namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Enter firstnumber : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter secondnumber : ");
            number2 = int.Parse(Console.ReadLine());

            for(int i = number1; i <= number2; i++)
            {
                int sum = 0;

                for(int j = 1; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        sum += j;
                    }
                }
                if(sum == i)
                {
                    Console.WriteLine($"{i} is perfect number");
                }

            }
        }
    }
}
