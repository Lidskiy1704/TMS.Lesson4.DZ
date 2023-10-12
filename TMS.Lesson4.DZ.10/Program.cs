namespace TMS.Lesson4.DZ._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 10, 15, 20, 25 };
            int[] array2 = { 3, 8, 13, 18, 23 };

            Console.WriteLine("Массив 1:");
            foreach (int num in array1)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nМассив 2:");
            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }

            double average1 = CalculateAverage(array1);
            double average2 = CalculateAverage(array2);

            Console.WriteLine("\nСреднее арифметическое для массива 1: " + average1);
            Console.WriteLine("Среднее арифметическое для массива 2: " + average2);

            if (average1 > average2)
            {
                Console.WriteLine("Среднее арифметическое для массива 1 больше.");
            }
            else if (average2 > average1)
            {
                Console.WriteLine("Среднее арифметическое для массива 2 больше.");
            }
            else
            {
                Console.WriteLine("Средние арифметические равны.");
            }
        }

        static double CalculateAverage(int[] array)
        {
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }
    }
}