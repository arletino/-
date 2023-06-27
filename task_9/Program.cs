ArrayTasksFromFile Tasks = new ArrayTasksFromFile(); // read task from file task.txt

Utils Utils = new Utils(); // utils for checking numbers getting digitals in numbers and count digitals in number

Promt(PrintNumbers, Tasks.ArrayTasks()[0], "Введите начало и конец через запятую: ");

Promt(GetSumOfNumbers, Tasks.ArrayTasks()[1], "Введите начало и конец через запятую: ");

Promt(Akkerman, Tasks.ArrayTasks()[2], "Введите m и n через запятую; ");


void Promt(Delegate method, string? task, string? taskStr = "", int length = 2, int left =1, int right = 10, bool typeOfNumbers = false)
{
do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine(); 
        int[] arraySize = new int[length];
        Utils.StringToNumbersArray(str, arraySize, length);
        
        bool flag = true;
        foreach (int item in arraySize)
        {
            if (item <= 0) 
                {
                    flag = false;
                    break;
                } 
        } 
        if (!Utils.StringToNumbersArray(str, arraySize, length) || !flag)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else 
        {
            System.Console.WriteLine(method.DynamicInvoke(arraySize[1], arraySize[0]));
             
            Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

int GetSumOfNumbers(int end, int start)
{
//     if (start==end) { return start;}
//     else { 
//            if (start < end) 
//                 {return  end + GetSumOfNumbers( start, end-1 );}
//             else
//                 {return start + GetSumOfNumbers( start-1, end);}
//     }
// }
 
 if (start == end) return start;
 else if (start < end) return  end + GetSumOfNumbers( start, end-1);
 else return start + GetSumOfNumbers( start-1, end);
}

void PrintNumbers(int end, int start = 1)
{   
    if (end != 0) 
    {
        System.Console.Write($" {end} ");
        PrintNumbers(end-1, start);  
    }
}


int Akkerman(int m, int n)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
