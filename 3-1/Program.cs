using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
while (true)
{
    Console.WriteLine("Выберите программу, которую вы хотите запустить");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножения ");
    Console.WriteLine("3. Вывод делителей числа ");
    Console.WriteLine("4. Закрыть программу ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            GuessNumber();
            break;
        case "2":
            TableMultiply();
            break;
        case "3":
            AllDivisors();
            break;
        case "4":
            Exit();
            break;
    }
}
static void TableMultiply()
{
    int[,] Table = new int[10, 10];
    for (int row = 0; row < 10; row++)
    {
        for (int col = 0; col < 10; col++)
        {
            Table[row, col] = (row + 1) * (col + 1);
            Console.Write(Table[row, col] + "\t");
        }
        Console.WriteLine("\n\n");
    }
}

static void GuessNumber()

{
    Random x = new();
    int numc = x.Next(101);
    Console.WriteLine("Компьютер загадал целое число от 0 до 100\n");
    while (true)
    {
        string nump = Console.ReadLine();
        int intnump = Convert.ToInt32(nump);
        if (intnump != numc)
        {
            Console.WriteLine("Поробуйте снова!");
        }
        else
        {
            Console.WriteLine("Правильно!\n\n");
            break;
        }
    }
}

static void AllDivisors()
{
    double i = 0;
    Console.WriteLine("Введите число:");
    string num = Console.ReadLine();
    double intnum = Convert.ToDouble(num);
    Console.Write("\nДелителями числа являются: ");
    do
    {
        if (intnum % i == 0)
        {
            Console.Write(i + " ");
        }
        i++;
    } while (i != intnum + 1);
    Console.WriteLine("");

}

static void Exit()
{
    Console.WriteLine("\n Вы вышли из пограммы!\n\n");
    Environment.Exit(0);
}
