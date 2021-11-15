using EyeRoll.Classes.Fields_Inherit;
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
        public int Width { get; set; }
        public int Height { get; set; }

        private float angle;
        private int vel;

        public override void Drop()
        {
            angle = 0; 
            vel = Direction == "Horizontal" ? init_position.X : init_position.Y;
        }

        public override Point Update(int speed)
        {
            int VS = 300;

            vel += 4 * speed;
            int val = (int)(VS * Math.Sin(angle) + (Direction == "Horizontal" ? init_position.Y : init_position.X));
            angle += 0.1f * speed;

            if (Direction == "Horizontal")
            {
                if (vel > init_position.X + Width / 2) vel = init_position.X - Width / 2;
                return new Point(vel, val);
            }
            else
            {
                if (vel > init_position.Y + Height / 2) vel = init_position.Y - Height / 2;
                return new Point(val, vel);
            }
        }
    }
}
