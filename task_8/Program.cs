
ArrayTasksFromFile Tasks = new ArrayTasksFromFile(); // read task from file task.txt

Utils Utils = new Utils(); // utils for checking numbers getting digitals in numbers and count digitals in number

Promt(SortRowMarix, Tasks.ArrayTasks()[0], "Введите размеры массива через запятую", 2);

Promt(MinSummRowEl, Tasks.ArrayTasks()[1], "Введите размеры массива через запятую", 2);

MatrixMulti();

Promt(GetUnicArray, Tasks.ArrayTasks()[3], "Введите размеры массива через запятую", 3);

Promt(GetSpiralArray, Tasks.ArrayTasks()[4], "Введите размеры массива через запятую", 2);

void Promt(Delegate method, string? task, string? taskStr = "", int length = 0, int left =1, int right = 10, bool typeOfNumbers = false)
{
do
    {
        Console.Clear();
        System.Console.WriteLine(task);
        System.Console.Write($"Введите {taskStr}: ");
        string? str = Console.ReadLine(); 
        int[] arraySize = new int[length];
        Utils.StringToNumbersArray(str, arraySize, length);
       System.Console.WriteLine(string.Join(';', arraySize));
        
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
            method.DynamicInvoke(arraySize);
             
            Console.WriteLine("Для перехода к другой задаче нажмите 'ESC' или любую клавишу для повтора");
        }    
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
}

void GetSpiralArray(int[] arrayDimenssions)
{
    int m = arrayDimenssions[0];
    int n = arrayDimenssions[1];
    Console.Clear();
    int temp = 0;
    int[,] array = new int[m,n];
    int j = 0;
    int i = 0;
    int k = 0;
    int x = m;
    int y = n;
    int l = 0;
    Console.SetCursorPosition(j*4,i*2);
    System.Console.Write($"{array[i,j].ToString("D2")} ");

    while(temp < m*n - 1)
    {
        if(j < y-1 && i == k) 
            {
                j++;
                temp +=1;
                array[i,j] = temp;
                Console.SetCursorPosition(j*4,i*2);
                System.Console.Write($"{array[i,j].ToString("D2")} ");
            }
        if (j == y-1 && i < x-1)
            {
                i++;
                temp +=1;
                array[i,j] = temp;
                Console.SetCursorPosition(j*4,i*2);
                System.Console.Write($"{array[i,j].ToString("D2")} ");
            }
        if (j == y && i < x && x > y)
            {
                i++;
                temp +=1;
                array[i,j] = temp;
                Console.SetCursorPosition(j*4,i*2);
                System.Console.Write($"{array[i,j].ToString("D2")} ");
            }
        if (i == x-1 && j > l-1 && x-1 !=k)
        {
            j--;
            temp +=1;
            array[i,j] = temp;
            Console.SetCursorPosition(j*4,i*2);
            System.Console.Write($"{array[i,j].ToString("D2")} ");
        }
        if (i > k+1 && j == l)
        {
            i--;
            temp +=1;
            array[i,j] = temp;
            Console.SetCursorPosition(j*4,i*2);
            System.Console.Write($"{array[i,j].ToString("D2")} ");
        }
        if (i-1 == k && j ==l)
           {
            k++;
            y--;
            x--;
            l++;
           }    
            Thread.Sleep(400);
        }
    Console.SetCursorPosition(0,array.GetLength(0)*2+1);  
}

bool chekElement(int[,,] array, int element)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                        {
                           if (element == array[j, k ,i]) flag = true;  
                        }
                }
        }
    return flag;
} 

void GetUnicArray(int[] arrayDimenssions)

{
    int m = arrayDimenssions[0];
    int n = arrayDimenssions[1];
    int l = arrayDimenssions[2];
    int[,,] array = new int[m, n, l];
    Random rnd = new Random();
    int element = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                        {
                           do
                           {
                                element = rnd.Next(1, 10*m*n*l);
                           }
                           while(chekElement(array, element));
                           array[j, k, i] = element; 
                        }
                }
        }
    PrintArrayPos(array);
}

void PrintArrayPos(int[,,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
                {
                 Console.Write($"{array[j, k, i].ToString("D3")} ({j},{k},{i}) ");          
                }
        Console.WriteLine();
        }
      Console.WriteLine(); 
    }   
}

void MinSummRowEl(int[] arraySize)
{
    int[,] array = new int[arraySize[0], arraySize[1]];
    Utils.FillMatrixRandomInt(array);
    int[] SummElements = new int[array.GetLength(0)];
    

    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    SummElements[i] += array[i,j];
                    Console.Write($"{array[i, j].ToString("D2")} ");
                           
                } 
            Console.WriteLine($"  --> {SummElements[i]}");
        }
    int minSumm = SummElements[0];
    int indxMinSumm = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minSumm > SummElements[i]) 
        {
            minSumm = SummElements[i];
            indxMinSumm = i;
        }
    }
    Console.WriteLine($"Минимальная сумма = {minSumm}, в строке - {indxMinSumm}");
}


void MatrixMulti()
{
 
    
    int length = 2;
    Console.Clear();
    System.Console.WriteLine(Tasks.ArrayTasks()[2]);
    System.Console.Write($"Введите размеры матрицы 1 через запятую: ");
    string? str = Console.ReadLine(); 
    int[] arraySize = new int[length];
    Utils.StringToNumbersArray(str, arraySize, length);
    bool flag = Utils.StringToNumbersArray(str, arraySize, length);
    int[,] matrixA = new int[arraySize[0], arraySize[1]];
    Utils.FillMatrixRandomInt(matrixA);
    Utils.PrintMatrix(matrixA);
    System.Console.Write("Кол-во строк матрицы 2 должно равнятся кол-ву столбцов матрицы 1 \n Введите размеры матрицы 2: ");
    str = Console.ReadLine(); 
    Utils.StringToNumbersArray(str, arraySize, length);
    flag = Utils.StringToNumbersArray(str, arraySize, length);
    int[,] matrixB = new int[arraySize[0], arraySize[1]];
    Utils.FillMatrixRandomInt(matrixB);
    Utils.PrintMatrix(matrixB);
    System.Console.WriteLine();

    if (matrixB.GetLength(0) == matrixA.GetLength(1) && flag)
    {

    int[,] MultiArray = new int[matrixA.GetLength(0),matrixB.GetLength(1)];

    for (int k = 0; k < matrixA.GetLength(0); k++)
    {
        for (int i = 0; i < matrixB.GetLength(1); i++)
        {
            for (int j = 0; j < matrixB.GetLength(0); j++)
                {
                    MultiArray[k,i] += matrixA[k,j]*matrixB[j,i];
                    System.Console.Write($"{matrixA[k,j]}*{matrixB[j,i]} ");

                    if (j < matrixB.GetLength(0) - 1) 
                        {
                            System.Console.Write("+");
                        }
                    else
                        {
                        System.Console.WriteLine($" = {MultiArray[k,i]}");
                        }
                }
        }
    }
    System.Console.WriteLine("Результирующая матрица:");
    Utils.PrintMatrix(MultiArray);
    }
    else System.Console.WriteLine("Такие матрицы нельзя перемножать :)");
 System.Console.WriteLine();
}

void SortRowMarix(int[] arraySize)
{
    int[,] matrix = new int[arraySize[0], arraySize[1]];
    Utils.FillMatrixRandomInt(matrix);
    Utils.PrintMatrix(matrix);
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1)-1; k++)
        {
            for (int j = 0; j < matrix.GetLength(1)-k-1; j++)
            {
                if (matrix[i,j] < matrix[i, j+1])
                {
                    temp = matrix[i,j];
                    matrix[i,j] = matrix[i,j+1];
                    matrix[i,j+1] = temp; 
                }
            }
        }
    }
    System.Console.WriteLine("Отсортированная матрица");
    Utils.PrintMatrix(matrix);
}