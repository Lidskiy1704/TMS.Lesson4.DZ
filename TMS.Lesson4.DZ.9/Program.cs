namespace TMS.Lesson4.DZ._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");

            if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 0)
            {
                int[] randomArray = new int[arraySize];
                Random random = new Random();

                for (int i = 0; i < arraySize; i++)
                {
                    randomArray[i] = random.Next(1, 101);
                }

                int max = randomArray[0];
                int min = randomArray[0];
                int sum = 0;

                foreach (int num in randomArray)
                {
                    if (num > max)
                        max = num;
                    if (num < min)
                        min = num;
                    sum += num;
                }

                double average = (double)sum / arraySize;

                Console.WriteLine("Сгенерированный массив:");
                foreach (int num in randomArray)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine("\nМаксимальное значение: " + max);
                Console.WriteLine("Минимальное значение: " + min);
                Console.WriteLine("Среднее значение: " + average);
            }
            else
            {
                Console.WriteLine("Некорректный ввод размера массива. Пожалуйста, введите положительное целое число.");
            }
        }
    }
}