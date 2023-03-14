using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCreation
{
    using System;
    using System.Collections.Generic;
    class FLat
    {
        public int FlatSK { get; set; }
        public string Code { get; set; }
        public string Vendor { get; set; }
        public string Side { get; set; }
        public byte District { get; set; }
        public bool Elevator { get; set; }
        public decimal NumberOfRooms { get; set; }
        public short FloorArea { get; set; }
        public decimal Price { get; set; }
    }
}
