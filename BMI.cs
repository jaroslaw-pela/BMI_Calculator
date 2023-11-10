using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class BMI
    {
        List<BMI> list = new List<BMI>();
        private double MassKg { get; set; }

        private double GrowthM { get; set; }

        public BMI(double massKg, double growth)
        {
            MassKg = massKg;
            GrowthM = growth;

            //Program.newPerson


            //var newPerson = new BMI(massKg, growth);
            //list.Add(newPerson);
        }

        public void AddToList(BMI newPerson)
        {
            list.Add(newPerson);
            Console.WriteLine("Informacja: dodano nowy pomiar do listy");
        }
    }
}
