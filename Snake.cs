using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Snake
    {
        public PictureBox SnakePicture { get; set; }
        public BodyPart Head { get; set; }
        public BodyPart Tail { get; set; }

        public Snake(PictureBox snakePicture)
        {
            SnakePicture = snakePicture;
            Tail = new BodyPart() { Location = new Point(snakePicture.Location.X, snakePicture.Location.Y) };
            Head = Tail;
        }
    }
}
