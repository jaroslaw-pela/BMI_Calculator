using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class Calculator
    {


        public Calculator(double bmiIndex)
        {
            if (bmiIndex > 25 && bmiIndex < 29.9)
            {
                Console.WriteLine("nadwagę");
            }
            else if (bmiIndex > 18.5 && bmiIndex < 24.9)
            {
                Console.WriteLine("masa prawidłowa, oby tak dalej!");
            }
            else if (bmiIndex >= 30)
            {
                Console.WriteLine("otyłość\nzgłoś się do lekarza: zamow.porade@mp.pl");
            }
            else if (bmiIndex < 18.5)
            {
                Console.WriteLine("niedowagę");
            }
            else
                Console.WriteLine("błąd momiaru");
        }
    }
}
