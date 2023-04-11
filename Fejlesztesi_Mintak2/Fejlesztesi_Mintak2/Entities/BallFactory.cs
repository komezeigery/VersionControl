using Fejlesztesi_Mintak2.Abstraction;
using Fejlesztesi_Mintak2.Abstratcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlesztesi_Mintak2.Entities
{
    public class BallFactory : ToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
