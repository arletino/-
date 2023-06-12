
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);

// int size = 5;
// int[] array = new int[size];
// Random rand = new Random();
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = rand.Next(100, 1000);
//     if (array[i] % 2 == 0)
//     {
//         count = count +1;
//     }

// }
// Console.WriteLine($"Созданный массив:[{string.Join("; ",array)}]");
// Console.WriteLine($"Кол-во четных элементов - {count}");

// int[][] array2D = new int [2][];
// array2D[0] = new int[2] {1,2};
// array2D[1] = new int[2] {3,4};
// for (int i = 0; i < 2; i++)
// {
//     System.Console.WriteLine(string.Join("; ", array2D[i]));
// }

    
string[] ch = {"\u00B0", "\u00B1", "\u00B2", "\u00B3", "\u00B4", "\u00B5",
                "\u00B6", "\u00B7", "\u00B8","\u00B9, \u00B10 "};
for (int i = 0; i < ch.Length; i++)
{
Console.WriteLine(ch[i]);
}