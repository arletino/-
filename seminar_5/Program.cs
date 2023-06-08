
int size = 5;
int[] array = new int[size];
Random rand = new Random();
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count = count +1;
    }

}
Console.WriteLine($"Созданный массив:[{string.Join("; ",array)}]");
Console.WriteLine($"Кол-во четных элементов - {count}");
