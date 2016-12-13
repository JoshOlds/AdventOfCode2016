using System;

namespace Advent2016
{
    public class Day8 : IExecutable
    {
        public void Execute()
        {

            Console.WriteLine("Advent of Code 2016 - Day 8");
            
            MiniLCD lcd = new MiniLCD(50, 6);
            lcd.LiveDisplay = true;

            string[] inputArr = null;

            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day8.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach(string s in inputArr)
            {
                if (s.Contains("rect"))
                {
                    int startIndex = s.IndexOf(" ");
                    int secondIndex = s.IndexOf("x");
                    string firstNum = s.Substring(startIndex + 1, secondIndex - (startIndex + 1));
                    string secondNum = s.Substring(secondIndex + 1, s.Length - (secondIndex + 1));
                    int width = Int32.Parse(firstNum);
                    int height = Int32.Parse(secondNum);
                    lcd.Rect(width, height);
                }
                if(s.Contains("rotate"))
                {
                    string[] split =  s.Split('=');
                    string data = split[1];
                    int startIndex = 0;
                    int secondIndex = data.LastIndexOf(" ");
                    string firstNum = data.Substring(startIndex, data.IndexOf(" "));
                    string secondNum = data.Substring(secondIndex + 1, data.Length - (secondIndex + 1));
                    int index = Int32.Parse(firstNum);
                    int amount = Int32.Parse(secondNum);
                    if(s.Contains("row")) lcd.RotateRow(index, amount);
                    if(s.Contains("column")) lcd.RotateColumn(index, amount);   
                }
            }

            
            lcd.Display();
            Console.WriteLine("Pixels on: " + lcd.PixelOnCount());

        }

        
    }
}