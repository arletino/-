public class Utils

{
    public int[] CheckNumber(string? str, int sign= 0)
    {
         int number;
         int [] resultChecking;
         if (int.TryParse(str, out number))
        {
            if (sign == 0) 
            {
                sign = CountSignsInNumber(number);
            }

            if (Math.Pow(10, sign-1) <= Math.Abs(number) 
                    && Math.Abs(number) < Math.Pow(10, sign) || (number == 0 && sign == 0) )     

            {
                resultChecking = new int[] {sign, number};
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
    
    public int GetSignFromNumber(int number, int position = 0)
    {
        
        return  Math.Abs(number / Convert.ToInt32(Math.Pow(10, (CountSignsInNumber(number) - (position)))) % 10);  
    }

    public int CountSignsInNumber(int number)
    {
    int count = 0;
    int temp = number;
        while (temp != 0)
       {
            temp /= 10;
            count += 1; 
        }
    return count;
    }

    public bool StringToNumbersArray(string? str, int[] numbers, int countNumbers = 2)
    {
    string? [] stringNumbers = str.Split(','); 
    for (int i = 0; i < stringNumbers.Length; i++)
    {
      
      if (CheckNumber(stringNumbers[i])[0] == -1 || stringNumbers.Length > countNumbers) 
      {
        return false;
      }
    numbers[i] = CheckNumber(stringNumbers[i])[1];
    }
    return true;
    }
   
   public void FillArrayRandomInt(int[] array, int left, int right)
    {
        Random temp =new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = temp.Next(left, right);
        }
    }
   
    public void FilltArrayRandomDouble(double[] array)
    {
        Random temp =new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(temp.NextDouble()*10, 2);
        }
    }

    public void FillDArrayRandomInt(int[,] array, int left = 1, int right = 10)
    {
        Random temp =new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; i < array.GetLength(1); j++)
            {
                array[i, j] = temp.Next(left, right);
            }
        }
    }
}