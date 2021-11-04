using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes.Figures
{
    class PathSquare : Path
    {
        private float angle = 0;
        private float smoothing = 0.05f;

        public PathSquare(Point init_position) : base(init_position) { }

        public override void Drop()
        {
            angle = 0;
        }

        public override Point Update(int speed)
        {
            
        }
    }
}
