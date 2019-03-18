using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }
        public override void Move(Random random)
        {
            // Your code will go here

            int chance = random.Next(3);

            if (this.HitPoints >= 1)
            {
                switch (chance)
                {
                    case 0:
                        break;
                    default:
                        base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
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
