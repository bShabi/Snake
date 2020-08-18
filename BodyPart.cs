using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class BodyPart
    {
        public Point Location { get; set; }
        public BodyPart Next { get; set; }
    }
}
