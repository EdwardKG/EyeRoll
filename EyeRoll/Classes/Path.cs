using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRoll.Classes
{
    abstract class Path
    {
        public Point init_position { get; set; }
        public abstract void Drop();
        public abstract Point Update(int speed);
    }
}