using EyeRoll.Classes.Fields_Inherit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathInfinity : Path, ISmoothingPath
    {
        private float angle = 0;
        public float Smoothing { get; set; }

        public PathInfinity(Point init_position) : base(init_position) { }

        public override void Drop()
        {
            angle = 0;
        }

        public override Point Update(int speed)
        {
            int HS = 150, VS = 300; // ширина и высота

            int x = (int)(VS * Math.Sin(angle) + init_position.X);
            int y = (int)(HS * Math.Cos(Math.PI / 2 + angle * 2) + init_position.Y);

            angle += Smoothing * speed;
            return new Point(x, y);
        }
    }
}
