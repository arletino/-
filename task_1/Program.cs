ConsoleKeyInfo key;
int taskNumber;
bool flg = false;
string[] HomeTask = new string[4];
do
{
        Console.Clear();

        Console.WriteLine("Программа - \"Домашнее задание №1\"");

        Console.WriteLine("Задано 4-е задачи:");
        HomeTask[0] =@"Задача 2: Напишите программу, которая на вход принимает два числа 
        и выдаёт, какое число большее, а какое меньшее.
        Пример:
                a = 5; b = 7 -> max = 7
                a = 2 b = 10 -> max = 10
                a = -9 b = -3 -> max = -3";
        HomeTask[1] =@"Задача 4: Напишите программу, которая принимает на вход три числа 
        и выдаёт максимальное из этих чисел.
        Пример:
                2, 3, 7 -> 7
                44 5 78 -> 78
                22 3 9 -> 22";
        HomeTask[2] =@"Задача 6: Напишите программу, которая на вход принимает число 
        и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        Пример:
                4 -> да
                -3 -> нет
                7 -> нет";
        HomeTask[3] =@"Задача 8: Напишите программу, которая на вход принимает число (N),
        а на выходе показывает все чётные числа от 1 до N.
        Пример:
                5 -> 2, 4
                8 -> 2, 4, 6, 8";
        foreach (string Task in HomeTask) System.Console.WriteLine(Task);
        System.Console.Write("Введите номер задачи чтобы увидить решение, для выхода нажмите \"ESC\" - ");
        key = Console.ReadKey(true);
        Console.WriteLine();
        
        if (int.TryParse(key.KeyChar.ToString(),out taskNumber))
        {
                flg = false;
                
                switch (taskNumber)
                {
                case 2:
                        flg = true;
                        HomeTask1_2();
                        break;
                case 4:
                        flg = true;
                        HomeTask1_4();
                        break;
                case 6:
                        flg = true;
                        HomeTask1_6();
                        break;
                case 8:
                        flg = true;
                        HomeTask1_8();
                        break;
                default:
                        flg = false;
                        break;
                }
        }
} 
  
while (key.Key != ConsoleKey.Escape);

Console.Clear();
Console.WriteLine("Досвидания");
Thread.Sleep(1000);
Console.Clear();

void HomeTask1_2()
{
        int[] ab = new int[2];
        int i = 0;
        while (i<2)
        {
        Console.Clear();
        System.Console.WriteLine(HomeTask[0]);
        System.Console.WriteLine("Решение:");
        System.Console.Write($"Введите {i+1}-е число - ");
        if (int.TryParse(Console.ReadLine(), out ab[i])) i++;
        else
                {
                System.Console.WriteLine("Вы ввели не число повторите ввод");
                Thread.Sleep(500);
                } 
        }
        if (ab[0] > ab[1]) Console.WriteLine($"{ab[0]} > {ab[1]}");
        else if (ab[0] < ab[1]) Console.WriteLine($"{ab[0]} < {ab[1]}");
        else Console.WriteLine($"{ab[0]} = {ab[1]}");
Thread.Sleep(2000);
Console.Write("Нажмите любую клавишу для возврата в меню выбора задач");
ConsoleKeyInfo key1;
key1 = Console.ReadKey(true);
}
void HomeTask1_4()
{
        int[] ab = new int[3];
        int i = 0;
        while (i<3)
        {
        Console.Clear();
        System.Console.WriteLine(HomeTask[1]);
        System.Console.WriteLine("Решение:");
        System.Console.Write($"Введите {i+1}-е число - ");
        if (int.TryParse(Console.ReadLine(), out ab[i])) i++;
        else
                {
                System.Console.WriteLine("Вы ввели не число повторите ввод");
                Thread.Sleep(500);
                } 
        }
        int max = ab[0];
        System.Console.Write("Числа: ");
        for (i = 0; i < ab.Length; i++) 
        {
        System.Console.Write($" {ab[i]} ");
        if (max < ab[i]) max = ab[i];
        }
        System.Console.WriteLine();
        Console.WriteLine($"Самое большое число - {max}");
Thread.Sleep(2000);
Console.Write("Нажмите любую клавишу для возврата в меню выбора задач");
ConsoleKeyInfo key1;
key1 = Console.ReadKey(true);
}
void HomeTask1_6()
{
        int ab;
        do
        {
                Console.Clear();
                System.Console.WriteLine(HomeTask[2]);
                System.Console.WriteLine("Решение:");
                System.Console.Write($"Введите число для проверки на четность - ");
                bool flg = int.TryParse(Console.ReadLine(), out ab);
        if (!flg)   
                {
                        System.Console.WriteLine("Вы ввели не число повторите ввод");
                        Thread.Sleep(500);
                } 
        } while(!flg);
        if (ab % 2 == 0) Console.WriteLine($"Число {ab} - четное");
        else Console.WriteLine($"Число {ab} - не четное");

Thread.Sleep(2000);
Console.Write("Нажмите любую клавишу для возврата в меню выбора задач");
ConsoleKeyInfo key1;
key1 = Console.ReadKey(true);
}

void HomeTask1_8()
{
        int ab;
        do
        {
        Console.Clear();
        System.Console.WriteLine(HomeTask[3]);
        System.Console.WriteLine("Решение:");
        System.Console.Write($"Введите число - ");
        bool flg = int.TryParse(Console.ReadLine(), out ab);
        if (!flg | ab == 0)   
                {
                System.Console.WriteLine("Вы ввели не число или \"0\" повторите ввод");
                Thread.Sleep(500);
                } 
        }while(!flg | ab == 0);
        Console.WriteLine($"Четные числа от 0 до {ab} :");
        if (ab > 0) 
        {
                for (int i = 1; i <= ab; i++)
                        {
                                if (i % 2 == 0) Console.Write($"{i} ");
                        }

        }
        else
        {
                for (int i = ab; i < 0; i++)
                        {
                                if (i % 2 == 0) Console.Write($"{i} ");
                        }
        }
System.Console.WriteLine();
Thread.Sleep(2000);
Console.Write("Нажмите любую клавишу для возврата в меню выбора задач");
ConsoleKeyInfo key1;
key1 = Console.ReadKey(true);
}