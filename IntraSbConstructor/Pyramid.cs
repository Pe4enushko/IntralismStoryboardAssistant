using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntraSbConstructor
{
    public class Pyramid
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        
        public double GetCenterY() => Height / 2;
        
        public double GetSideCenterX() => (Height / 2) * Math.Tan(90);
        
        public double GetSideLength()
        {
            double diagonal = Math.Sqrt(Width*Width + Length * Length);
            return Math.Sqrt(Math.Pow(diagonal / 2, 2) + Height * Height);
        }

        public double GetSidePosX() => Width / 4;

        public double GetSidePosZ() => Length / 4;
        
        public double GetDegreesY() =>  Math.Atan2(Width, Length) * 180 / Math.PI;

        public double GetDegreesZ()
        {
            double diagonal = Math.Sqrt(Width * Width + Length * Length);
            return Math.Atan2(Height, (diagonal / 2)) * 180 / Math.PI;
        }
    }
}
