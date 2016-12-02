using System;

namespace Advent2016
{



    public class KeyPad13 : IKeyPad
    {

        private int CurrentNumber;

        public KeyPad13(int startingNumber = 5)
        {
            CurrentNumber = startingNumber;
        }

        public int SetNumber(int newNumber)
        {
            if (newNumber > 13 || newNumber < 1)
            {
                Console.WriteLine("Error: KeyPad.cs: 'Cannot set keypad number to value: " + newNumber);
                return CurrentNumber;
            }
            CurrentNumber = newNumber;
            return CurrentNumber;
        }

        public string GetFormattedNumber()
        {
            string num = CurrentNumber.ToString();
            switch (num)
            {
                case "10":
                    num = "A";
                    break;
                case "11":
                    num = "B";
                    break;
                case "12":
                    num = "C";
                    break;
                case "13":
                    num = "D";
                    break;
            }
            return num;
        }

        public int MoveUp()
        {
            if (CurrentNumber != 1 && CurrentNumber != 2 && CurrentNumber != 4 && CurrentNumber != 5 && CurrentNumber != 9)
            {
                if (CurrentNumber == 3 || CurrentNumber == 13)
                {
                    CurrentNumber -= 2;
                }
                else
                {
                    CurrentNumber -= 4;
                }
            }
            return CurrentNumber;
        }

        public int MoveDown()
        {
            if (CurrentNumber != 13 && CurrentNumber != 12 && CurrentNumber != 10 && CurrentNumber != 9 && CurrentNumber != 5)
            {
                if (CurrentNumber == 1 || CurrentNumber == 11)
                {
                    CurrentNumber += 2;
                }
                else
                {
                    CurrentNumber += 4;
                }
            }
            return CurrentNumber;
        }

        public int MoveLeft()
        {
            if (CurrentNumber != 5 && CurrentNumber != 2 && CurrentNumber != 10 && CurrentNumber != 1 && CurrentNumber != 13)
            {
                CurrentNumber -= 1;
            }
            return CurrentNumber;
        }

        public int MoveRight()
        {
            if (CurrentNumber != 9 && CurrentNumber != 12 && CurrentNumber != 4 && CurrentNumber != 1 && CurrentNumber != 13)
            {
                CurrentNumber += 1;
            }
            return CurrentNumber;
        }

        public int GetNumber()
        {
            return CurrentNumber;
        }
    }

}