namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, a;
            Console.Write(" Enter an integer number : ");
            input = int.Parse(Console.ReadLine());    

            for (int i = input; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
