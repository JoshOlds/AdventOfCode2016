namespace Advent2016{

    public enum EDirection {North, East, South, West};

    public class Direction{

        public EDirection CurrentDirection { get; set; }

        public Direction(EDirection dir = EDirection.North)
        {
            CurrentDirection = dir;
        }

        public EDirection TurnRight()
        {
            if(CurrentDirection == EDirection.West)
            {
                CurrentDirection = EDirection.North;
            }
            else
            {
                CurrentDirection++;
            }
            return CurrentDirection;
        }

        public EDirection TurnLeft()
        {
            if(CurrentDirection == EDirection.North)
            {
                CurrentDirection = EDirection.West;
            }
            else
            {
                CurrentDirection--;
            }
            return CurrentDirection;
        }

    }
}