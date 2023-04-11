﻿using Fejlesztesi_Mintak2.Abstratcion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlesztesi_Mintak2.Entities
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile(@"Images/car.png");
            g.DrawImage(imageFile, 0, 0, Width, Height);
        }
    }
}
