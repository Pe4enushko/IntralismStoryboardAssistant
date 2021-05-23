using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IntraSbConstructor
{
    public class Polygon
    {
        public Polygon (double size, double height, int angleCount)
        {
            AngleCount = angleCount;
            Size = size; 
            OneAngle = GetRadians();
            Side = GetSideSize();
            Height = height;
        }
        public double Size { get; set; }

        public double Side { get; }
        public double Height { get; }
        public double AngleCount { get; set; }

        public double OneAngle { get; }

        /// <summary>
        /// Get angle between 2 edges in radians
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        private double GetRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
        /// <summary>
        /// Get angle between 2 edges in radians
        /// </summary>
        /// <returns></returns>
        private double GetRadians()
        {
            return GetDegrees() * (Math.PI / 180);
        }
        public double GetDegrees()
        {
                return 360 / AngleCount;
        }

        public double[] GetPositionsX()
        {
            double[] ArrayX = new double[(int)AngleCount];
            for (int i = 1, j = 0; i <= ArrayX.Length; j++, i++)
            {
                ArrayX[j] = Math.Round(Math.Cos(GetRadians() * i - GetRadians() / 2) * (Size / 2), 4);
                Console.WriteLine(ArrayX[j]);
            }
            return ArrayX;
        }

        public double[] GetSidePositionsX()
        {
            double[] ArrayX = new double[(int)AngleCount + 1];
            for (int i = 0, j = 0; i < ArrayX.Length; j++, i++)
            {
                ArrayX[j] = Math.Round(Math.Cos(GetRadians() * i) * (Size / 2), 4);
            }
            return ArrayX;
        }

        public double[] GetPositionsZ()
        {
            double[] ArrayZ = new double[(int)AngleCount];
            for (int i = 1, j = 0; i <= ArrayZ.Length; j++, i++)
            {
                ArrayZ[j] = Math.Round(Math.Sin(GetRadians() * i - GetRadians() / 2) * (Size / 2), 4);
                Console.WriteLine(ArrayZ[j]);
            }
            return ArrayZ;
        }
        public double[] GetSidePositionsZ()
        {
            double[] ArrayZ = new double[(int)AngleCount + 1];
            for (int i = 0, j = 0; i < ArrayZ.Length; j++, i++)
            {
                ArrayZ[j] = Math.Round(Math.Sin(GetRadians() * i) * (Size / 2),4);
            }
            return ArrayZ;
        }

        public double[] GetAngles()
        {
            double[] degrees = new double[(int)AngleCount];
            for (int i = 0; i < AngleCount; i++)
            {
                degrees[i] = ((180 - GetDegrees()) / 2) - GetDegrees() * i;
            }
            return degrees;
        }

        private double GetSideSize()
        {
                return Math.Round(Size * Math.Sin(GetRadians()/2),4);
        }
    }
}
