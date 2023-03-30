namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  number;
            Console.Write("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            int count = 0;
            bool is_prime;
            for(int i = 2; i <= number; i++) 
            {
                is_prime = true;
                for(int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                    count++;
                }
                if(is_prime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
