using System;
using System.Collections.Generic;
namespace InterviewProblem
{
    public class System
    {
        /// <summary>
        /// Constructor for initialzing the system given an array of integers
        /// </summary>
        /// <param name="input"></param>
        List<int> list = new List<int>();
        public System(int[] input)
        {
            // for (i = 0; <= input.length, i++)
            // {
            //     this.Add(input[i]);
            // }

            this.list = new List<int>(input);
            Console.WriteLine("\nInitial input/list:");
            list.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();
        }

        /// <summary>
        /// Add a new number to the system
        /// </summary>
        /// <param name="number"></param>
        public void Add(int number)
        {
            this.list.Add(number);
            Console.WriteLine("\nAdd: " + number.ToString() + "\nNowInput List =");
            list.ForEach(i => Console.Write("{0}\t", i));
        }

        /// <summary>
        /// Calculate the average of the numbers currently in the system
        /// </summary>
        /// <returns>The average as defined by number total divided by the total count of numbers</returns>
        public double GetAverage()
        {
            double avg = this.GetSum(0, this.list.Count) / this.list.Count;
            Console.WriteLine("\nGetAverage:" + avg.ToString());
            return avg;
        }

        /// <summary>
        /// Count the number of times appears in the system
        /// </summary>
        /// <param name="number">The number to be counted</param>
        /// <returns></returns>
        public int GetCount(int number)
        {
            int count = 0;
            foreach (int item in this.list)
            {
                if (number == item)
                {
                    count++;
                }
            }
            Console.WriteLine("\nGetCount:" + count.ToString());
            return count;

        }

        /// <summary>
        ///    Given a range designated by the start and end positions, 
        ///    Calculate the sum between them. This should inclusive
        /// </summary>
        /// <param name="start">Start position</param>
        /// <param name="end">Ending position</param>
        /// <returns></returns>
        public int GetSum(int start, int end)
        {
            int sum = 0;
            foreach (int item in this.list)
            {
                sum += item;
            }
            Console.WriteLine("\nGetSum:" + sum.ToString());
            return sum;
        }
    }
}