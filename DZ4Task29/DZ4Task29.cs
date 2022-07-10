// Напишите программу, которая задаёт случайный массив случайного размера 
// (от 5 до 10) элементов (значение элементов от 1 до 40) 
// и выводит на экран массив квадратов этих чисел.
// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]

namespace DZ
{
    class Task29
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int lengthArray = SetArayLenth();
            int[] array = new int[lengthArray];
            FillArray(array);

            Console.WriteLine($"Сгенерирован массив из {lengthArray} элементов: [{string.Join(",",array)}]"); // Нашёл в интернете такой вариант вывода массива в одну строку =)
            
            int[] newArray = new int[lengthArray];

            Console.WriteLine("--------------------------------");

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i] * array[i];
            }
            Console.WriteLine($"Массив квадратов этих чисел: [{string.Join(",",newArray)}]");
            Console.ReadKey();
        }

        public static int SetArayLenth()
        {
            int length = new Random().Next(5, 11);
            return length;
        }

        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 41);
            }
        }
    }
}

