using EyeRoll.Classes.Fields_Inherit;
using System;
using System.Drawing;

namespace EyeRoll.Classes.Figures
{
    class PathHoppingDot : Path, ISmoothingPath, IDirectionPath, ILocationBox
    { 
        public float Smoothing { get; set; }
        public string Direction { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        Random rand = new Random();

        public override void Drop()
        {
            
        }

        public override Point Update(int speed)
        {
            int diffX = ((init_position.X * 2) - Width) / 2;
            int diffY = ((init_position.Y * 2) - Height) / 2;
            int x = rand.Next(LocationX , Width + diffX);
            int y = rand.Next(LocationY, Height + diffY);

            return new Point(x, y);
        }
    }
}
