﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Journey
{
    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
        }

        public override string Name
        {
            get
            {
                return "Niebieska mikstura";
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
            game.IncreasePlayerHealth(5, random);
        }
    }
}
