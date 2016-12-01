using System;

namespace Advent2016
{
    public class Coordinate : IEquatable<Coordinate>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Coordinate other)
        {
            if(this.X == other.X && this.Y == other.Y)
            {
                return true;
            }
            return false;
        }

        public Coordinate Clone(){
            return new Coordinate(X, Y);
        }
    }

}

