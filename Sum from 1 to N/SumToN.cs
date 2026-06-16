using System;

namespace Sum_from_1_to_N;

public class SumToN
{
    public static int SumToNum(int n)
    {
        if(n == 0)
        {
            return 0;
        }

        return n + SumToNum(n-1);
    }
}
