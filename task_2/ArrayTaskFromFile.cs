public class ArrayTasksFromFile
{
    public string[] Text()
    {
        string path = "task.txt";
        return File.ReadAllLines(path);
    }
    public int[] PositionTasks()
    {
        int j = 0;
        for (int i = 0; i < Text().Length; i++)
            {
                if (Text()[i].Contains("Задача"))
                {
                    j++;
                }
            }
        int[] positionTask = new int[j];
        j = 0;
        for (int i = 0; i < Text().Length; i++)
            {
                if (Text()[i].Contains("Задача"))
                {
                    positionTask[j] = i;
                    j++;
                }
            }
        return positionTask;
    }
    public string[] ArrayTasks()
    {
        //int j = 0;
        string[] tasks = new string[PositionTasks().Length];
        for (int i = 0, j = 0; i < Text().Length; i++)
            {
                if (Text()[i].Contains("Задача"))
                {
                    j++;
                }
                tasks[j - 1] += Text()[i] + Environment.NewLine;
            }
        return tasks;
    }

    public void PrintTask()
     {    
        Console.Clear();
        for (int i = 0; i < ArrayTasks().Length; i++)
            {
                System.Console.Write(ArrayTasks()[i]);
            }
        System.Console.WriteLine();
        System.Console.Write("Используйте стрелочки для выбора задчи. \nНажмите Ввод для подтверждения или нажмите \"ESC\" для выхода ");
     }

}

