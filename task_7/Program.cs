ArrayTasksFromFile Tasks = new ArrayTasksFromFile(); // read task from file task.txt

Utils Utils = new Utils(); // utils for checking numbers getting digitals in numbers and count digitals in number



int[,] matrix = new int[5, 5];
double[,] array;

do
    {
        Console.Clear();
        System.Console.WriteLine(Tasks.ArrayTasks()[0]);
        System.Console.Write($"Введите : ");
        string? str = Console.ReadLine(); 
        int[] arraySize = new int[2];
        Utils.StringToNumbersArray(str, arraySize); 
        if (!Utils.StringToNumbersArray(str, arraySize ) || arraySize[0] < 0 || arraySize[1] < 0)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else
        {
            array = new double[arraySize[0], arraySize[1]];
            FillArrayD(array);
            PrintMatrixD(array);

        }
        Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");   
    } while (Console.ReadKey().Key != ConsoleKey.Escape);


do
    {
        Console.Clear();
        System.Console.WriteLine(Tasks.ArrayTasks()[1]);
        System.Console.Write($"Введите позиции элемента через запятую: ");
        string? str = Console.ReadLine(); 
        int[] arraySize = new int[2];
        Utils.StringToNumbersArray(str, arraySize); 
        if (!Utils.StringToNumbersArray(str, arraySize ) || arraySize[0] < 0 || arraySize[1] < 0)
        {
            System.Console.WriteLine("Вы ввели не правильные данные, для перехода к другой задаче нажмите 'ESC'");
            System.Console.WriteLine("Или любую клавишу для повтора");
        }
        else
        {
            
            FillArrayI(-10, 10, matrix);
            PrintMatrixI(matrix);
            GetElement(arraySize[0], arraySize[1], matrix);
        }
        Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");   
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
Console.Clear();
Console.WriteLine(Tasks.ArrayTasks()[2]);
PrintMatrixI(matrix);
MeanColoms(matrix);

GetSumElementsMainDiag(matrix);




 void FillArrayI(int left, int right, int[,] matrix)
{
    Random temp = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp.Next(left, right);
        }            
    }
}
void FillArrayD(double [,] matrix)
{
    Random temp = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((temp.NextDouble() - temp.NextDouble()) * 10, 2);
        }            
    }
}
void GetElement(int row, int colom, int[,] matrix)
{
    if (row < matrix.GetLength(0) && colom < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Запрашиваемый элемент - {matrix[row, colom]}");
    }
    else
    {
        System.Console.WriteLine("Нет такого элемента");
    }
}
void MeanColoms(int [,] matrix)
{
    double[] mean = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
           mean[i] += (matrix[j,i]); 
        }
        mean[i] = Math.Round(mean[i] / matrix.GetLength(0), 2);
        System.Console.Write("{0,7:F1}", "^  ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine(string.Join(" | ", mean));
}
void GetSumElementsMainDiag(int [,] matrix)
{
    int limit;
    double sumElemets = 0;
    if (matrix.GetLength(0)> matrix.GetLength(1)) limit = matrix.GetLength(1);
    else limit = matrix.GetLength(1);
    for (int i = 0; i < limit; i++)
    {
        sumElemets += matrix[i,i];
        System.Console.Write(matrix[i,i]);
        if (i < limit-1) System.Console.Write(" + ");
        else System.Console.Write(" = ");
    }
    System.Console.WriteLine(sumElemets);
}   
void PrintMatrixI(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,7:F1}",$"{ matrix[i, j]}|");
        }
        Console.WriteLine();            
    }
}

void PrintMatrixD(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,7:F1}",$"{ matrix[i, j]}|");
        }
        Console.WriteLine();            
    }
}
