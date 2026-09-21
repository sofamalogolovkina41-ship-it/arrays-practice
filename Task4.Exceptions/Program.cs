using System;

class Program
{
    static void Main()
    {

        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            while (true)
            {
                Console.Write($"Введите элемент [{i}]: ");

                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    break;   // успех — переходим к следующему элементу
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        Console.Write("Введите индекс для вывода (0-4): ");

        try
        {
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Элемент [{index}] = {arr[index]}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: индекс должен быть целым числом.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Ошибка: Индекс вне границ массива.");
        }
    }
}