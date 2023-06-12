﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
string numbers = String.Empty; 
System.Console.WriteLine("Задача 41: Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("Введите целые числа через запятую");
string date = Console.ReadLine();

string[] NumbersSpliter(string str, string spliter)
{
    return str.Split(new [] { spliter } ,StringSplitOptions.RemoveEmptyEntries);
}

string[] strNumbers = NumbersSpliter(date, ",");

int CountMinusNum(string[] array)
{
    int number = 0;
    int count = 0;    
    for (int i = 0; i < strNumbers.GetLength(0); i++)
    {
        if (int.TryParse(strNumbers[i], out number) && number > 0) count++;
    }
    System.Console.WriteLine($"Кол-во элементов > 0 - {count}");
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return count;
}
int count = CountMinusNum(strNumbers);

System.Console.WriteLine("Задача 43: Найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ");
System.Console.Write("Введите k1= ");
int kOne = int.Parse(Console.ReadLine());
System.Console.Write("Введите b1= ");
int bOne = int.Parse(Console.ReadLine());
System.Console.Write("Введите k2= ");
int kTwo = int.Parse(Console.ReadLine());
System.Console.Write("Введите b2= ");
int bTwo = int.Parse(Console.ReadLine());

double [] PointsCrossLines(int k, int b, int kk, int bb)
{
    double[] tochka = new double[2];
    tochka[0] = (double)(bb-b)/(k-kk);
    System.Console.WriteLine($"x({tochka[0]}) = (b2({bb})-b1({b})= {bb-b})/(k1({k})-k2({kk})={k-kk})");
    tochka[1] = (double)(k*tochka[0]+b);
    System.Console.WriteLine($"y({tochka[1]}) = k1({k})*x({tochka[0]}) + (b2({bb})-b1({b}) ");
    System.Console.WriteLine($"Точка пересечения - ({tochka[0]}, {tochka[1]}) ");
    System.Console.WriteLine("Нажмите Enter для продолжения");
    Console.ReadLine();
    Console.Clear();
    return tochka;
}
double[] CrosTochka = PointsCrossLines(kOne,bOne,kTwo,bTwo);