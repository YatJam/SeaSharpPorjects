namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /* this is an ok example of method overloading but the method is wet, 
        see the refactored method below that also accounds for null exceptions
        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
        */

        //refactored version of method overloading with calls other move method as refactor
        public void Move(Point newLocation)
        {
            // this is an example of defensive programming to stop the app from going to a weird or invalid state
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
}