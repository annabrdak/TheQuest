using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location; //Since protected properties are only available to subclasses, the form object can’t set the location…only read it through the public get method we define.
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            Point moverLocation = this.location;

            if (Math.Abs(moverLocation.X - locationToCheck.X) < distance &&
               (Math.Abs(moverLocation.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // pomysł KK
        /*public bool Nearby(Point locationToCheck, double distance)
        {
            Point moverLocation = this.location;

            double deltaX = Math.Abs(moverLocation.X - locationToCheck.X);
            double deltaY = Math.Abs(moverLocation.Y - locationToCheck.Y);


            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY) < Convert.ToDouble(distance)
      }*/

        public Point Move(Direction direction, Rectangle boundaries)
        {
           // Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (location.Y - MoveInterval >= boundaries.Top)
                        location.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (location.Y + MoveInterval <= boundaries.Bottom)
                        location.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (location.X - MoveInterval >= boundaries.Left)
                        location.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (location.X + MoveInterval <= boundaries.Right)
                        location.X += MoveInterval;
                    break;
                default: break;
            }
            return location;
        }
    }
}

