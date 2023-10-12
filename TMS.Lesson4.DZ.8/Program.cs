namespace TMS.Lesson4.DZ._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9}; 

            Console.Write("Введите число для удаления: ");

            int numberToRemove = Convert.ToInt32(Console.ReadLine());
            
            int[] newNumbers = numbers.Where(num => num != numberToRemove).ToArray();

            if (newNumbers.Length != numbers.Length)
            {
                Console.WriteLine($"Число {numberToRemove} было удалено из массива.");

                Console.WriteLine("Новый массив без указанного числа:");
                foreach (int num in newNumbers)
                {
                    Console.Write(num + " ");
                }
            }
            else
                {
                    Console.WriteLine($"Число {numberToRemove} не найдено в массиве.");
                }
        }
    }
}