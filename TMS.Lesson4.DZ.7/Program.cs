namespace TMS.Lesson4.DZ._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var numberOfUser = Convert.ToInt32(Console.ReadLine());

            if (Array.Exists(numbers, element => element == numberOfUser)) 
            {
                Console.WriteLine($"Число {numberOfUser} присутствует в масиве");
            }
            else 
            {
                Console.WriteLine($"Числа {numberOfUser} в массиве нет");
            }
        }
    }
}