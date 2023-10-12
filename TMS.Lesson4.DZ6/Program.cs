namespace TMS.Lesson4.DZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i++)
            {
                int square = i * i;
                Console.WriteLine($"Квадрат числа {i} равен {square}");
            }
        }
    }
}