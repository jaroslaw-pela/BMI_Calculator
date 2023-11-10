using System;
using System.Collections.Generic;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          __        ___          \r\n __ __    )_)  )\\/)  )    __  __ \r\n    --   /__) (  ( _(_    --     \r\n                                 \r\n  _                              \r\n / ` _   ) _      ) _  _)_ _   _ \r\n(_. (_( ( (_ (_( ( (_( (_ (_) )  \r\n\n\n\n                                 ");

            double x = 0;
            double y = 0;

            BMI bmi = new BMI(x,y);

            Console.WriteLine("Podaj swoją masę [kg]");
            var mass = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPodaj swój wzrost [m]");
            var growth = Convert.ToDouble(Console.ReadLine());

            var newPerson = new BMI(mass, growth);

            bmi.AddToList(newPerson);

            double bmiIndex = mass / (growth * growth);
            Console.WriteLine("\nTwój index BMI wynosi: " + String.Format("{0:N2}", bmiIndex));


            Console.Write("A to oznacza: "  );
            var calculator = new Calculator(bmiIndex);


        }
    }
}