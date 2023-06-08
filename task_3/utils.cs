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

    int CountSignsInNumber(int number)
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
}