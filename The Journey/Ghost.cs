﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Journey
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {
        }

        public override void Move(Random random)
        {
            // do ukonczenia str 509
        }
    }
}