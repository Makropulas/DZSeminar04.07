// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

namespace DZ
{
    class Task25
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1;

            Console.WriteLine("--------------------------------");

            for (int i = 1; i < num2; i++)
            {
                result = result * num1;
            }
            Console.WriteLine($"Число {num1} возведённое в степень {num2} равняется {result}");
        }
    }
}

// Решение без цикла

// namespace DZ
// {
//     class Task25
//     {
//         static void Main(string[] args)
//         {
//             Console.Clear();
//             Console.Write("Введите число: ");
//             int num1 = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите степень: ");
//             int num2 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("--------------------------------");

//             Console.WriteLine($"Число {num1} в степени {num2} равняется {Math.Pow(num1, num2)}");
//         }
//     }
// }