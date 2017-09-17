using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxDifference
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[][] inputArray = new int[][]
            {
                new int[] {2,4,1,0},
                new int[] {1,1,1,1},
                new int[] {-1,4,10,3,-2}
            };

            for (int x=0; x < inputArray.Length; x++)
            {
                int result = FindMaxDifference(inputArray[x]);
                Console.WriteLine("Maximum Difference= " + result);
            }

           
            Console.ReadLine();
        }

        public static int FindMaxDifference( int[] inputArray )
        {
            int maxDiff = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == 0)  // First index is compared to second index..
                    maxDiff = Math.Abs(inputArray[i] - inputArray[i + 1]);
                else if (i == (inputArray.Length - 1))
                {
                    if (maxDiff < (Math.Abs(inputArray[i - 1] - inputArray[i])))  
                        maxDiff = Math.Abs(inputArray[i - 1] - inputArray[i]);  
                }
                else
                {
                    if (maxDiff < (Math.Abs(inputArray[i - 1] - inputArray[i])))  // Absolute difference between i and the previous one
                        maxDiff = Math.Abs(inputArray[i - 1] - inputArray[i]);
                        
                    if (maxDiff < (Math.Abs(inputArray[i - 1] - inputArray[i])))
                        maxDiff = Math.Abs(inputArray[i - 1] - inputArray[i]);                        
                }
            }
            return maxDiff;
        }
    }
}
