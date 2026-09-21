using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rnd.Next(1, 101);   

        Console.WriteLine("Массив: " + string.Join(", ", arr));

        long sum = 0;
        foreach (int x in arr) sum += x;
        Console.WriteLine($"Сумма: {sum}");

        double product = 1;
        foreach (int x in arr) product *= x;
        Console.WriteLine($"Произведение: {product:E2}");

        int evenCount = 0;
        foreach (int x in arr) if (x % 2 == 0) evenCount++;
        Console.WriteLine($"Чётных чисел: {evenCount}");

        double avg = (double)sum / arr.Length;
        int aboveAvg = 0;
        foreach (int x in arr) if (x > avg) aboveAvg++;
        Console.WriteLine($"Больше среднего ({avg:F1}): {aboveAvg}");
    }
}