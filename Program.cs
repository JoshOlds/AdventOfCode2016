using System;

namespace Advent2016
{
    public interface IExecutable
    {
        void Execute();
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Instantiate a new class of any given day, and run execute() to view results.");
            //Example:
            //IExecutable program = new Day1();
            //program.execute();

            IExecutable program = new Day9();
            program.Execute();
        }
    }
}
