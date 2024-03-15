using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Computer
    {
        public int CompID { get; set; }
        public string CompName { get; set; }
        public string CompCPU { get; set; }
        public int CompCPUclockspeed { get; set; }
        public int CompRamSize { get; set; }
        public int CompHDDsize { get; set; }
        public int CompGPUvram { get; set; }
        public double CompPrice { get; set; }
        public int CompQuantity { get; set; }
    }
}
