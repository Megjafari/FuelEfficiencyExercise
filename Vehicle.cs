using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelEfficiencyExercise
{
    public class Vehicle
    {
        public string Name { get; set; }
        public double FuelConsumption { get; set; } // in liters per mil

        public virtual void CalculateEfficiency()   //virtual metod som kan overrideas
        {
            double distance = 10 / FuelConsumption;
            Console.WriteLine($"{Name} kan köra {distance} mil på 10 liter bränsle.");
        }
    }
}
