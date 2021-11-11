using EyeRoll.Classes.Fields_Inherit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathCircle : Path, ISmoothingPath
    {
        private float angle = 0;
        public float Smoothing { get; set; }


        public override void Drop()
        {
            angle = -1;
        }

        public override Point Update(int speed)
        {
            int HS = 300, VS = 300;

            int x = (int)(HS * Math.Cos(angle) + init_position.X);
            int y = (int)(VS * Math.Sin(angle) + init_position.Y);
            angle += Smoothing * speed;

            return new Point(x, y);
        }
    }
}
