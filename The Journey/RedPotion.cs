using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Journey
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location)
        {
        }

        public override string Name
        {
            get
            {
                return "Czerwona mikstura";
            }
        }

        public bool Used
        {
            get
            {
                return true;
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
        }
    }
}
