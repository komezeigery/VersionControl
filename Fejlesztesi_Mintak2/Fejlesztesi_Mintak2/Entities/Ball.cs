using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fejlesztesi_Mintak2.Entities
{
    public class Ball : Label
    {
        public Ball()
        {
            Width = 50;
            Height = Width;
            AutoSize = false;
            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            var brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, 0, 0, Width, Height);
        }

        public void MoveBall()
        {
            Left += 1;
        }
    
    }
}
