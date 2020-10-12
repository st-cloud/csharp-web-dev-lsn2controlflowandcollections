using System;
using System.Collections.Generic;

namespace ListExercises
{
    public class SumOfEvenNumbers
    {
        public static int SumEven (List<int> integers)
        {
            int sum = 0;

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    sum += integers[i];
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
