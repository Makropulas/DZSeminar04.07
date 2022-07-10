// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

namespace DZ
{
    class Task27
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число: ");
            string? str = Console.ReadLine();
            int number = Convert.ToInt32(str);
            int sum = 0;

            Console.WriteLine("--------------------------------");

            if (number < 0)
            {
                Console.WriteLine("Число не должно быть отрицательным");
            }
            else if (number >=0 && number <= 9)
            {
                Console.WriteLine("Нечего складывать! Введите число, состоящее минимум из двух цифр");
            }
            else
            {
                for (int i = 0; i < str?.Length; i++)
                {
                    sum = sum + Convert.ToInt32(str[i].ToString());
                }
                Console.Write($"Сумма цифр в числе {number} = {sum}");
            }
        }
    } 
}
