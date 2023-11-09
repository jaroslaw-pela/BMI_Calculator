using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class BMI
    {

        private double MassKg { get; set; }

        private double Growth { get; set; }

        public BMI(double massKg, double growth)
        {
            MassKg = massKg;
            Growth = growth;
        }


    }
}
