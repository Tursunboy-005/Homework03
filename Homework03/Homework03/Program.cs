namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
               Console.Write("Enter a dec number: ");
               int decimalNumber = int.Parse(Console.ReadLine());
               Console.WriteLine("Binary representation: {0}", Convert.ToString(decimalNumber, 2));

         }
    }
}