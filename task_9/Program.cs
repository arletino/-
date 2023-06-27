
int GetSumOfNumbers(int start, int end)
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
System.Console.WriteLine(GetSumOfNumbers(4, 8));
