using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Journey
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {
        }

        public override string Name
        {
            get
            {
                return "Buława";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            // do uzupelnienia str 511

            int directionToAttack = (int)direction;

            for(int i = 0; i < 4; i++)
            {
                DamageEnemy((Direction)directionToAttack, 20, 6, random);
                directionToAttack++;
            }
        }
    }
}
