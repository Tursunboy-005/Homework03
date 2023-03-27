namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int num1, num2, num3, num4;
                int smallest, largest;

                Console.WriteLine("Enter four integers:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                num3 = int.Parse(Console.ReadLine());
                num4 = int.Parse(Console.ReadLine());

                smallest = num1;
                largest = num1;

                if (num2 < smallest) smallest = num2;
                if (num2 > largest) largest = num2;

                if (num3 < smallest) smallest = num3;
                if (num3 > largest) largest = num3;

                if (num4 < smallest) smallest = num4;
                if (num4 > largest) largest = num4;

                Console.WriteLine($" Result  : {largest} , {smallest}");

        }
    }
}
