using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
            switch (direction)
            {
                case Direction.Up:
                    if (DamageEnemy(direction, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Right, 10, 3, random)) break;                    
                    else if (DamageEnemy(Direction.Left, 10, 3, random)) break;
                    break;
                   
                case Direction.Down:
                    if (DamageEnemy(direction, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Left, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Right, 10, 3, random)) break;
                    break;
                    
                case Direction.Left:
                    if (DamageEnemy(direction, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Up, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Down, 10, 3, random)) break;
                    break;
                    
                case Direction.Right:
                    if (DamageEnemy(direction, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Down, 10, 3, random)) break;
                    else if (DamageEnemy(Direction.Up, 10, 3, random)) break;
                    break;                    
                default:
                    break;
            }

        }
    }
}

