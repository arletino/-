ArrayTasksFromFile Tasks = new ArrayTasksFromFile();

int [] CheckNuber(string? str, int sign= 0)
{
     int count = 0;
     int number;
     int temp;
     int [] resultChecking;
     if (int.TryParse(str, out number))
    {
        if (sign == 0) 
        {
            temp = number;
            while (temp != 0)
            {
                temp /= 10;
                count += 1; 
            }
        sign = count;
        }
    
        if (Math.Pow(10, sign-1) <= Math.Abs(number) 
                && Math.Abs(number) < Math.Pow(10, sign) || (number == 0 && sign == 0) )     
     
        {
            resultChecking = new int[] {0, number};
            return resultChecking;
        }
        else 
        {
            resultChecking = new int[] {-1, number};
            return resultChecking;
        }
    }
    else 
    {
        resultChecking = new int[] {-1, number};
        return resultChecking;
    }
}

int getSignFromNumber(int number, int position = 0)
{
    return  Math.Abs(number / Convert.ToInt32(Math.Pow(10, (Math.Abs(number).ToString().Length - (position)))) % 10);  
}



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

void SecondSingFinder(string? task, string? taskStr = "данные", int position = 1, int sign = 0)
{
    int[] resultChecking = new int [2] {-1, -1};
    do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine();
        resultChecking = CheckNuber(str, sign); 
        if (resultChecking[0] != 0)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
            Thread.Sleep(1000);
        }
        else 
        {
            System.Console.WriteLine($"{position}-я цифра вашего трехзначного числа = {getSignFromNumber(resultChecking[1], position)}");
            System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            Thread.Sleep(1000);
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void FirdSingFinder(string? task, string? taskStr = "данные", int position = 1, int sign = 0)
{
    int[] resultChecking = new int [2] {-1, -1};
    do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine();
        resultChecking = CheckNuber(str, sign);
        if (resultChecking[0] != 0)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
            Thread.Sleep(1000);
        }
        else if (-100 < resultChecking[1] && resultChecking[1] < 100  )
        {
            System.Console.WriteLine($"Ввашем числе {resultChecking[1]} нет третий цифры");
            System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            Thread.Sleep(1000);
        }
        else 
        {
            System.Console.WriteLine($"{position}-я цифра вашего трехзначного числа = {getSignFromNumber(resultChecking[1], position)}");
            System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            Thread.Sleep(1000);
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

void CheckDayHollyday(string? task)
    {
        string [] arrayDaysInWeek = {"Monday","Thusday","Wensday","Thirstday","Friday", "Saturday","Sunday"};
        int[] resultChecking = new int [2] {-1, -1};
        do
        {
            Console.Clear();
            System.Console.WriteLine(task);
            System.Console.Write("Пожалуйста введите номер дня недели, чтобы узнать является ли это день выходным - ");
            string? str = Console.ReadLine();
            resultChecking = CheckNuber(str); 
            if (resultChecking[0] != 0 || resultChecking[1] <= 0 || resultChecking[1] > 7 )
            {
                System.Console.WriteLine("Вы ввели не правильные данные, для выхода нажмите 'ESC'");
                System.Console.WriteLine("Или любую клавишу для повтора");
                Thread.Sleep(1000);
            }
            else if (resultChecking[1] > 4) 
                {
                    System.Console.WriteLine($"{arrayDaysInWeek[resultChecking[1]-1]} - Выходной");
                    System.Console.WriteLine("Для выхода нажмите 'ESC' или любую клавишу для повтора");
                    Thread.Sleep(1000);
                }
            else
            { 
                System.Console.WriteLine($"{arrayDaysInWeek[resultChecking[1]-1]} - Не выходной");
                System.Console.WriteLine("Для выхода нажмите 'ESC' или любую клавишу для повтора");
                Thread.Sleep(1000);
            }    
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

SecondSingFinder(Tasks.ArrayTasks()[0], "трёхзначное число", 2, 3 );

FirdSingFinder(Tasks.ArrayTasks()[1], "число", 3);

CheckDayHollyday(Tasks.ArrayTasks()[2]);