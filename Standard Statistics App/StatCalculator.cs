using System;
using System.Collections.Generic;
using System.Text;

namespace Standard_Statistics_App
{
    internal class StatCalculator
    {
        public static double Mean(double[] values)
        {
            // Edge case: handle empty arrays to prevent division by zero
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            double sum = 0;

            // Loop through the array to add up all the numbers
            foreach (double num in values)
            {
                sum += num;
            }

            // Divide sum by total count. 
            // We cast 'sum' to a double so the division keeps the decimal points.
            return (double)sum / values.Length;
        }

        public static double Median(double[] values)
        {
            // Edge case: handle empty arrays to prevent division by zero
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            Array.Sort(values);
            int n = values.Length;
            
            if(n % 2 != 0)
            {
                return values[n / 2];
            }
            else
            {
                double middleLeft = values[(n / 2) - 1];
                double middleRight = values[n / 2];

                return (middleLeft + middleRight) / 2.0;
            }
        }
    }
}
