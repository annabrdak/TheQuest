using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
           : base(game, location) { }
        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction direction, Random random)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (DamageEnemy(direction, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Left, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Down, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Right, 20, 6, random)) break;
                    break;

                case Direction.Down:
                    if (DamageEnemy(direction, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Right, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Up, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Left, 20, 6, random)) break;
      
                    break;

                case Direction.Left:
                    if (DamageEnemy(direction, 20, 6, random)) break;   
                    else if (DamageEnemy(Direction.Down, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Right, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Up, 20, 6, random)) break;
                    break;

                case Direction.Right:
                    if (DamageEnemy(direction, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Up, 20, 6, random)) break;
                    else if (DamageEnemy(Direction.Left, 20, 63, random)) break;
                    else if (DamageEnemy(Direction.Down, 20, 63, random)) break;
                    break;
                default:
                    break;
            }
        }
    }
}
