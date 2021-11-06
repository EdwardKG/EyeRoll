﻿using EyeRoll.Classes.Fields_Inherit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathSin : Path, IDirectionPath
    {
        public string Direction { get; set; }
        private float angle = 0;
        private int vel = 0;


        public override void Drop()
        {
            angle = 0; 
            vel = 0;
        }

        public override Point Update(int speed)
        {
            int VS = 300;

            vel += 4 * speed;
            int val = (int)(VS * Math.Sin(angle) + init_position.Y);
            angle += 0.1f * speed;

            if (Direction == "Horizontal")
            {
                if (vel > init_position.X * 2) vel = 0;
                return new Point(vel, val);
            }
            else
            {
                if (vel > init_position.Y * 2) vel = 0;
                return new Point(val, vel);
            }
        }
    }
}
