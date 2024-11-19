namespace Assignments_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            int num4 = int.Parse(Console.ReadLine());

            CalculateTotalAndAverage(out int total, out double average, num1, num2, num3, num4);

            Console.WriteLine($"The Total is: {total}");
            Console.WriteLine($"The Average is: {average}");
        }

        static void CalculateTotalAndAverage(out int total, out double average, params int[] numbers)
        {
            total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            average = (double)total / numbers.Length;
        }
    }
}
