using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }
        public override void Move(Random random)
        {
            // Your code will go here

            int chance = random.Next(2);

            if (this.HitPoints >= 1)
            {
                switch (chance)
                {
                    case 0:
                        base.location = Move((Direction)random.Next(4), game.Boundaries);
                        break;
                    case 1:
                        base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                        break;
                    default:
                        break;
                }
                if (NearPlayer())
                {
                    game.HitPlayer(1, random);
                }
            }                      

        }
    }
}
