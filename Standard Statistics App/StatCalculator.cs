using System;
using System.Collections.Generic;
using System.Text;

namespace Standard_Statistics_App
{
    internal class StatCalculator
    {
        public static double[] SortedValues(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return new double[0];
            }

            double[] sortedValues = (double[])values.Clone();
            Array.Sort(sortedValues);


            return sortedValues;
        }

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

        public static double Range(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            double highestValue = values[values.Length - 1];
            double lowestValue = values[0];

            return (highestValue - lowestValue);
        }

        public static void Largest_Smallest(double[] values, out double small, out double large)
        {
            if(values == null || values.Length == 0)
            {
                small = 0;
                large = 0;
                return;
            }

            small = values[0];

            large = values[values.Length - 1];

        }

    }
}
