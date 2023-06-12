ArrayTasksFromFile Tasks = new ArrayTasksFromFile(); // read task from file task.txt

Utils Utils = new Utils(); // utils for checking numbers getting digitals in numbers and count digitals in number

void Promt(Delegate method, string? task, string? taskStr = "", int sign = 0, int left =1, int right = 10, bool typeOfNumbers = false)
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
            if (typeOfNumbers)
            {
                double[] array = new double[resultChecking[1]];
                Utils.FillIntArrayRandomDouble(array);
                method.DynamicInvoke(array);
                System.Console.WriteLine($"Массив из {array.Length} чисел - [{string.Join("; ", array)}]");
            }
            else
            {
                int[] array = new int[resultChecking[1]];
                Utils.FillIntArrayRandomInt(array, left, right);
                method.DynamicInvoke(array);
                System.Console.WriteLine($"Массив из {array.Length} чисел - [{string.Join("; ", array)}]");
            }
            Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

void DevMaxMInArray(double[]array)
{
    var min = array[0];
    var max = array[0];
    foreach (var item in array)
    {
        if (item > max) max = item;
        if (item < min) min = item;        
    }
    var dev = max - min;
    Console.WriteLine($"Разница между минимальным и максимальным элементом = {dev}");
}

void SumNotEvenPos(int[] array)
{
    int sumNotEvenPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sumNotEvenPos += array[i];
    }
    System.Console.WriteLine($"Сумма элементов на не четных позициях = {sumNotEvenPos}");
}

void FillArray(int[] array)
{
int countEven = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0)
                    countEven += 1;
            }
            System.Console.WriteLine($"В массиве {countEven} - четных чисела");
}


string? welcomeStr = "кол-во элементов в массиве";

Promt(FillArray, Tasks.ArrayTasks()[0], welcomeStr, 0, 1, 100);

Promt(SumNotEvenPos, Tasks.ArrayTasks()[1], welcomeStr, 0, 1, 100);

Promt(DevMaxMInArray, Tasks.ArrayTasks()[2], welcomeStr, 0, 1, 100, true);

