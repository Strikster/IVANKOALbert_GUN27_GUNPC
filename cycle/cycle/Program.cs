using  System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Первые 10 чисел Фибоначчи:");
        int a = 0, b = 1;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(a);
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine(); 

       
        Console.WriteLine("Чётные числа от 2 до 20:");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(); 

       
        Console.WriteLine("Таблица умножения от 1 до 5:");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write($"{i * j}\t"); 
            }
            Console.WriteLine(); 
        }

        Console.WriteLine();


        // Задание 4: Ввод пароля
        string password = "qwerty";
        string userInput;
        do
        {
            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();
            if (userInput != password)
            {
                Console.WriteLine("Неверный пароль. Попробуйте еще раз.");
            }
        } while (userInput != password);

        Console.WriteLine("Пароль верный. Доступ предоставлен.");
    }
}

