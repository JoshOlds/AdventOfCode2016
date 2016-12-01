using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Advent2016
{
    public class Day1 : IExecutable
    {
        public void Execute()
        {
            Console.WriteLine("AdventOfCode 2016 - Day 1");

            string input = "L1, R3, R1, L5, L2, L5, R4, L2, R2, R2, L2, R1, L5, R3, L4, L1, L2, R3, R5, L2, R5, L1, R2, L5, R4, R2, R2, L1, L1, R1, L3, L1, R1, L3, R5, R3, R3, L4, R4, L2, L4, R1, R1, L193, R2, L1, R54, R1, L1, R71, L4, R3, R191, R3, R2, L4, R3, R2, L2, L4, L5, R4, R1, L2, L2, L3, L2, L1, R4, R1, R5, R3, L5, R3, R4, L2, R3, L1, L3, L3, L5, L1, L3, L3, L1, R3, L3, L2, R1, L3, L1, R5, R4, R3, R2, R3, L1, L2, R4, L3, R1, L1, L1, R5, R2, R4, R5, L1, L1, R1, L2, L4, R3, L1, L3, R5, R4, R3, R3, L2, R2, L1, R4, R2, L3, L4, L2, R2, R2, L4, R3, R5, L2, R2, R4, R5, L2, L3, L2, R5, L4, L2, R3, L5, R2, L1, R1, R3, R3, L5, L2, L2, R5";
            input = Regex.Replace(input, @"\s+", "");
            string[] inputs = input.Split(',');

            GridLocation myGrid = new GridLocation();
            List<Coordinate> visitedCoords = new List<Coordinate>();
            bool foundRepeat = false;

            foreach (string command in inputs)
            {
                string dir = command.Substring(0, 1);
                int distance = Int32.Parse(command.Substring(1, command.Length - 1));
                if (dir == "L")
                {
                    myGrid.Direction.TurnLeft();
                }
                if (dir == "R")
                {
                    myGrid.Direction.TurnRight();
                }

                for (int i = 0; i < distance; i++)
                {
                    myGrid.MoveForward(1);
                    if (foundRepeat == false && visitedBefore(myGrid.Coordinate, visitedCoords))
                    {
                        foundRepeat = true;
                        Console.WriteLine("I've been here before! : X:" + myGrid.Coordinate.X + " , Y:" + myGrid.Coordinate.Y);
                        Console.WriteLine("Total Distance: " + (Math.Abs(myGrid.Coordinate.X) + Math.Abs(myGrid.Coordinate.Y)));
                    }
                    visitedCoords.Add(myGrid.Coordinate.Clone());
                }





            }

            Console.WriteLine("X: " + myGrid.Coordinate.X + ", Y: " + myGrid.Coordinate.Y);
            Console.WriteLine("Total Distance: " + (Math.Abs(myGrid.Coordinate.X) + Math.Abs(myGrid.Coordinate.Y)));

        }

        private bool visitedBefore(Coordinate coord, IEnumerable<Coordinate> coordsArr)
        {
            bool found = false;
            foreach (Coordinate current in coordsArr)
            {
                if (current.Equals(coord))
                {
                    found = true;
                }
            }
            return found;
        }
    }
}