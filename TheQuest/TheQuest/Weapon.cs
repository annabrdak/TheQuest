using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Weapon :  Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location)
            : base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon() { PickedUp = true; }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
     /// overloaded Nearby() method - try not to repeat code
     
        public bool Nearby(Point enemyLocation, Point target, int distance)
        {
            base.location = target;
            return base.Nearby(enemyLocation, distance);
            
           /* if (Math.Abs(enemyLocation.X - target.X) < distance &&
               (Math.Abs(enemyLocation.Y - target.Y) < distance))
            {
                return true;
            }
            else
            {
                return false;
            } */

        }

        public Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            base.location = target;            
            target = base.Move(direction, boundaries);
            return target;
        }

    }
}
