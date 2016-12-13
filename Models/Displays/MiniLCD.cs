using System;
using System.Threading;

namespace Advent2016
{
    public class MiniLCD
    {
        private int xSize;
        private int ySize;
        private bool[,] pixels;
        public bool LiveDisplay;

        public MiniLCD(int xSize, int ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            pixels = new bool[xSize, ySize];
            LiveDisplay = false;
            Console.Clear();
            Console.CursorVisible = false;
        }

        public void Display(char displayChar = '*', char emptyChar = ' ')
        {
            if(LiveDisplay) Console.SetCursorPosition(0,0);
            Console.WriteLine("Starting Display Output");
            Console.WriteLine("------------------------");
            for (int y = 0; y < ySize; y++)
            {
                for (int x = 0; x < xSize; x++)
                {
                    if (pixels[x, y]) Console.Write(displayChar);
                    else Console.Write(emptyChar);
                }
                Console.Write('\n');
            }
            Console.WriteLine("------------------------");
            if(LiveDisplay) Thread.Sleep(100);
        }

        /// <summary>
        /// Rext(A,B) turns on all of the pixels in a rectangle at the top-left of the screen which is A wide and B tall.
        /// </summary>
        public void Rect(int width, int height)
        {
            if (width < 1 || width > xSize || height < 1 || height > ySize)
            {
                throw new Exception("Invalid height/width input");
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    pixels[x, y] = true;
                }
            }
            if(LiveDisplay) Display();
        }

        /// <summary>
        /// rotate row (A, B) shifts all of the pixels in row A (0 is the top row) right by B pixels. Pixels that would fall off the right end appear at the left end of the row.
        /// </summary>
        public void RotateRow(int row, int amount)
        {
            if (row < 0 || row > ySize) throw new Exception("Invalid Row");
            int shiftAmount = amount % xSize;
            for (int i = 0; i < shiftAmount; i++)
            {
                bool carryFlag = pixels[xSize - 1, row];
                for (int x = xSize - 2; x >= 0; x--)
                {
                    if (pixels[x, row]) pixels[x + 1, row] = true;
                    else pixels[x + 1, row] = false;
                }
                if (carryFlag) pixels[0, row] = true;
                else pixels[0, row] = false;
            }
            if(LiveDisplay) Display();
        }

        /// <summary>
        /// rotate column (A, B) shifts all of the pixels in column A (0 is the left column) down by B pixels. Pixels that would fall off the bottom appear at the top of the column.
        /// </summary>
        public void RotateColumn(int column, int amount)
        {
            if (column < 0 || column > xSize) throw new Exception("Invalid Row");
            int shiftAmount = amount % ySize;
            for (int i = 0; i < shiftAmount; i++)
            {
                bool carryFlag = pixels[column, ySize - 1];
                for (int y = ySize - 2; y >= 0; y--)
                {
                    if (pixels[column, y]) pixels[column, y + 1] = true;
                    else pixels[column, y + 1] = false;
                }
                if (carryFlag) pixels[column, 0] = true;
                else pixels[column, 0] = false;
            }
            if(LiveDisplay) Display();
        }

        public int PixelOnCount()
        {
            int count = 0;
            for(int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    if(pixels[x,y]) count++;
                }
            }
            return count;
        }
    }
}