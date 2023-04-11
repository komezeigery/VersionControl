﻿using Fejlesztesi_Mintak2.Abstratcion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fejlesztesi_Mintak2.Entities
{
    public class Ball : Toy
    {

        protected override void DrawImage(Graphics g)
        {
            var brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush, 0, 0, Width, Height);
        }
    
    }
}
