﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathEllipse : Path
    {
        private float angle = 0;
        private float smoothing = 0.05f;

        public PathEllipse(Point init_position) : base(init_position) { }

        public override void Drop()
        {
            angle = 0;
        }

        public override Point Update(int speed)
        {
            int HS = 300, VS = 150; // ширина и высота восьмерка

            int x = (int)(HS * Math.Cos(angle) + init_position.X);
            int y = (int)(VS * Math.Sin(angle) + init_position.Y);

            angle += smoothing * speed;
            return new Point(x, y);
        }
    }
}
