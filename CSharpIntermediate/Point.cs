using System;

namespace CSharpIntermediate
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Method overloading

        public void Move(Point newLocation)
        {

            //taking care of the case when newLocation is null
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");


            Move(newLocation.X, newLocation.Y);//simplier way
            //X = newLocation.X;
            //Y = newLocation.Y;
        }
    }
}
