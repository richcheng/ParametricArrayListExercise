using System;
using InterviewProblem;
namespace ConsoleParametric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main...");
            var input = new int[] { 8, 3, 5, 4, 5 };
            var solution = new InterviewProblem.System(input);
            solution.Add(5);
            solution.GetAverage(); //should be 30
            solution.GetCount(5);  // should have 3 '5'
            solution.GetSum(0, 1); // should be 11
            Console.WriteLine("press any key to quit");
            Console.ReadLine();
        }
    }
}