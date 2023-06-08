ArrayTasksFromFile Tasks = new ArrayTasksFromFile(); // read task from file task.txt

Utils Utils = new Utils(); // utils for checking numbers getting digitals in numbers and count digitals in number

void CheckPolindrom(string? task, string? taskStr = "",  int sign = 0)
{
    int[] resultChecking = new int [2] {-1, -1};
    do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine();
        resultChecking = Utils.CheckNumber(str, sign); 
        if (resultChecking[0] == -1 || resultChecking[1] < 0)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else 
        {
            bool flag = false;
            for (int i = 0; i < resultChecking[0] / 2; i++)
            {
                if (Utils.GetSignFromNumber(resultChecking[1], i+1) != Utils.GetSignFromNumber(resultChecking[1], resultChecking[0] - i))
                {
                    flag = false; 
                    break;
                }
            }
            
            if (!flag)
            {
                System.Console.WriteLine($"Число {resultChecking[1]} - палиндром");
                System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            }
            else
            {
                System.Console.WriteLine($"Число {resultChecking[1]} не является палиндромом");
                System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            }
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

void getCoordinats(string? task, string taskStr = "")
{
    int[] pointA = new int[3];
    int[] pointB = new int[3];
    do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите для первой точки {taskStr}: ");
        string? coordinats = Console.ReadLine();
        if (!stringToCordinates(coordinats, pointA))
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else
        {
            System.Console.Write($"Введите для второй точки {taskStr}: ");
            coordinats = Console.ReadLine();
        
            if (!stringToCordinates(coordinats, pointB))
            {
                System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
                System.Console.WriteLine("Или любую клавишу для повтора");
            }
            else
            {
                System.Console.WriteLine($"Расстояние между точками = {Math.Round(DistansIn3D(pointA, pointB), 2)}");
                System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
            }
        }

    } while (Console.ReadKey().Key != ConsoleKey.Escape);

}   

double DistansIn3D(int[] A, int[] B)
{
    return Math.Sqrt(Math.Pow((A[0] - B[0]),2)+Math.Pow((A[1] - B[1]),2) + Math.Pow((A[2]- B[2]),2));
}


bool stringToCordinates(string? str, int[] point)
{
    string [] stringPoint = str.Split(','); 
    for (int i = 0; i < stringPoint.Length; i++)
    {
      
      if (Utils.CheckNumber(stringPoint[i])[0] == -1 || stringPoint.Length != 3) 
      {
        return false;
      }
    point[i] = Utils.CheckNumber(stringPoint[i])[1];
    }
    return true;
}

void arrayCube(string? task, string? taskStr = "", int pow = 3)
{
    int[] resultChecking = new int [2] {-1, -1};
    do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine();
        resultChecking = Utils.CheckNumber(str); 
        if (resultChecking[0] == -1 || resultChecking[1] < 1)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else 
        {
            int[] arrayCube = new int[Math.Abs(resultChecking[1])];

            for (int i = 0; i < resultChecking[1]; i++)
            {
                arrayCube[i] = Convert.ToInt32(Math.Pow(i+1, pow)); 
            }
            
            System.Console.WriteLine($" Кубы чисел от 1 до {resultChecking[1]} - [{string.Join("; ", arrayCube)}]");
            System.Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

int sign = 5; // Quantity signs in number for checking

string? welcomeStr = "пятизначное число"; //string for welcome"Введите {welcomeStr}"

CheckPolindrom(Tasks.ArrayTasks()[0], welcomeStr, sign);

welcomeStr = "координаты через запятую";

getCoordinats(Tasks.ArrayTasks()[1], welcomeStr);

welcomeStr = "число N";

arrayCube(Tasks.ArrayTasks()[2], welcomeStr);