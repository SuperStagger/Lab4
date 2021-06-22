﻿using System.Windows.Forms;

namespace lab4
{
    public abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public abstract void DrawBlack(PictureBox p);
        public abstract void HideDrawingBackGround(PictureBox p);
        public void MoveRight(PictureBox p)
        {
            HideDrawingBackGround(p);
            x += 10;
            DrawBlack(p);

        }
    }
}
