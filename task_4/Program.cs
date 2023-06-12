ArrayTasksFromFile Tasks = new ArrayTasksFromFile(); // read task from file task.txt

Utils Utils = new Utils(); // utils for checking numbers getting digitals in numbers and count digitals in number

void MathPow(string? task, string? taskStr = "",  int sign = 0)
{
    int[] numberAndPow = new int [2];
    do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine(); 
        if (!Utils.StringToNumbersArray(str, numberAndPow, sign))
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else 
        {
            int result = numberAndPow[0]; 
            for (int i = 0; i < numberAndPow[1]-1; i++)
            {
               result *=numberAndPow[0];  
            }
                System.Console.WriteLine($"Число {numberAndPow[0]} в степени {numberAndPow[1]} = {result}");
                System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

void SumNumbers(string? task, string? taskStr = "",  int sign = 0)
{
do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine(); 
        int[] resultChecking = Utils.CheckNumber(str, sign); 
        if (resultChecking[0] == -1)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else 
        {
            int count = Utils.CountSignsInNumber(resultChecking[1]);
            int result = 0;
            for (int i = 0; i < count+1; i++)
            {
               result += Utils.GetSignFromNumber(resultChecking[1], i);  
            }
                System.Console.WriteLine($"Сумма цифр числа {resultChecking[1]} = {result}");
                Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

void FillArray(string? task, string? taskStr = "", int sign = 0, int left =1, int right = 100)
{
do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine(); 
        int[] resultChecking = Utils.CheckNumber(str, sign); 
        if (resultChecking[0] == -1 || resultChecking[1] <= 0)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else 
        {
            int[] array = new int[resultChecking[1]]; 
            Utils.FillIntArrayRandom(array, left, right);
            System.Console.WriteLine($"Массив из {resultChecking[1]} чисел - [{string.Join("; ", array)}]");
            Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

string? welcomeStr = "число и степень через запятую";
 MathPow(Tasks.ArrayTasks()[0],welcomeStr , 2 );

welcomeStr = "натуральное число";
SumNumbers(Tasks.ArrayTasks()[1], welcomeStr);

welcomeStr = "кол-во элементов в массиве";
FillArray(Tasks.ArrayTasks()[2], welcomeStr, 0);

