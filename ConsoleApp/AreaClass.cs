using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class AreaClass
    {
        public double Base;

        public double Height;

        public double Area;

        public void CalcAreaNull()
        {
            Area = 0.5 * Base * Height;
            Console.WriteLine("The area is: " + Area.ToString());
        }

        public double CalcAreaDouble()
        {
            return 0.5 * Base * Height;
        }
    }
}
