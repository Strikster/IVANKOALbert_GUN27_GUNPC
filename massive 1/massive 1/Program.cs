// See https://akusing System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1: Массив чисел Фибоначчи
        int[] fibonacciNumbers = new int[8];
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;
        for (int i = 2; i < fibonacciNumbers.Length; i++)
        {
            fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
        }

        Console.WriteLine("Числа Фибоначчи:");
        foreach (var number in fibonacciNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Задание 2: Массив названий месяцев
        string[] months = new string[12]
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };


        Console.WriteLine("Месяцы года:");
        foreach (var month in months)
        {
            Console.WriteLine(month);
        }

        // Задание 3: Двумерный массив (матрица) 3x3
        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = (int)Math.Pow(j + 2, i + 1);
            }
        }


        Console.WriteLine("Матрица 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }


        // Задание 4: ломанный массив


        double[][] jaggedArray = new double[3][];


        jaggedArray[0] = new double[] { 1, 2, 3, 4, 5 };


        jaggedArray[1] = new double[] { Math.E, Math.PI };


        jaggedArray[2] = new double[] { Math.Log(1, 10), Math.Log(10, 10), Math.Log(100, 10), Math.Log(1000, 10) };

        // Вывод результатов
        Console.WriteLine("Первый массив (числа от 1 до 5):");
        PrintArray(jaggedArray[0]);

        Console.WriteLine("Второй массив (константы e и pi):");
        PrintArray(jaggedArray[1]);

        Console.WriteLine("Третий массив (логарифмы по основанию 10):");
        PrintArray(jaggedArray[2]);
    }

    static void PrintArray(double[] array)
    {
        foreach (double num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Задание 5: копирование и перенос членов массива

        int[] array3 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };


        int numberOfElementsToCopy = 3;


        if (array2.Length >= numberOfElementsToCopy)
        {

            Array.Copy(array3, 0, array2, 0, numberOfElementsToCopy);


            Console.WriteLine("Массив array2 после копирования:");
            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("Во втором массиве недостаточно места для копирования элементов.");
        }


        // Задание 6: Изменение размера первого массива
        int newSize = array.Length * 2;
        Array.Resize(ref array, newSize);

        Console.WriteLine("Размер массива array изменён. Новые элементы не инициализированы:");
        PrintArray1(array3);
    }

    static void PrintArray1(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
