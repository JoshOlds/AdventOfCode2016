namespace Advent2016
{
    
    public class GridLocation
    {
        public Coordinate Coordinate { get; set; }
        public Direction Direction {get; set; }

        public GridLocation(int x = 0, int y = 0)
        {
            Coordinate = new Coordinate();
            Coordinate.X = x;
            Coordinate.Y = y;
            Direction = new Direction();
        }

        public Coordinate MoveForward(int distance){
            if(Direction.CurrentDirection == EDirection.North)
            {
                Coordinate.Y += distance;
            }
            if(Direction.CurrentDirection == EDirection.East)
            {
                Coordinate.X += distance;
            }
            if(Direction.CurrentDirection == EDirection.South)
            {
                Coordinate.Y -= distance;
            }
            if(Direction.CurrentDirection == EDirection.West)
            {
                Coordinate.X -= distance;
            }
            return Coordinate;
        }

        public Coordinate MoveBackwards(int distance){
            MoveForward(-distance);
            return Coordinate;
        }

    }

}
