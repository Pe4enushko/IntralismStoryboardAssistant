using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntraSbConstructor
{
    class Pyramid
    {
        private double height { get; set; }
        private double length { get; set; }
        private double width { get; set; }
        
        public double GetCenterY(double h)
        {
            return h / 2;
        }


    }
}
