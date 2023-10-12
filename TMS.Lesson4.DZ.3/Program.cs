namespace TMS.Lesson4.DZ._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Сумма чисел от 1 до {number} равна: {sum}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите целое положительное число.");
            }
        }
    }
}