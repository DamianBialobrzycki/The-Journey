﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Journey
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {
        }

        public override string Name
        {
            get
            {
                return "Miecz";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            // do uzupelnienia str 511

            int directionToAttack = (int)direction;

            if (!DamageEnemy(direction, 10, 3, random))
            {
                directionToAttack++;
                if (!DamageEnemy((Direction)directionToAttack, 10, 3, random))
                {
                    DamageEnemy((Direction)directionToAttack, 10, 3,random);
                }
            }
                
        }
    }
}
