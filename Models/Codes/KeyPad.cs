using System;

namespace Advent2016
{

    public interface IKeyPad
    {
        int GetNumber();
        int SetNumber(int newNumber);
        int MoveUp();
        int MoveRight();
        int MoveDown();
        int MoveLeft();

    }
    public class KeyPad : IKeyPad
    {
        private int CurrentNumber;

        public KeyPad(int startingNumber = 5)
        {
            CurrentNumber = startingNumber;
        }

        public int SetNumber(int newNumber)
        {
            if (newNumber > 9 || newNumber < 1)
            {
                Console.WriteLine("Error: KeyPad.cs: 'Cannot set keypad number to value: " + newNumber);
                return CurrentNumber;
            }
            CurrentNumber = newNumber;
            return CurrentNumber;
        }

        public int GetNumber()
        {
            return CurrentNumber;
        }

        public int MoveUp()
        {
            if (CurrentNumber > 3)
            {
                CurrentNumber -= 3;
            }
            return CurrentNumber;
        }

        public int MoveDown()
        {
            if (CurrentNumber < 7)
            {
                CurrentNumber += 3;
            }
            return CurrentNumber;
        }

        public int MoveLeft()
        {
            if (CurrentNumber != 1 && CurrentNumber != 4 && CurrentNumber != 7)
            {
                CurrentNumber -= 1;
            }
            return CurrentNumber;
        }

        public int MoveRight()
        {
            if (CurrentNumber != 3 && CurrentNumber != 6 && CurrentNumber != 9)
            {
                CurrentNumber += 1;
            }
            return CurrentNumber;
        }

    }

}