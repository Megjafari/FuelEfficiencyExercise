using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelEfficiencyExercise
{
    public class Motorcycles : Vehicle
    {
        public override void CalculateEfficiency()      //overridear metoden från basklassen
        {
            double distance = 10 / FuelConsumption;     //beräknar hur långt motorcykeln kan köra på 10 liter bränsle
            Console.WriteLine($"{Name} kan köra {distance} mil på 10 liter bränsle.");
        }
    }
}
