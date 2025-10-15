namespace FuelEfficiencyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Cars {  Name = "BMW", FuelConsumption = 0.8 };  // 0.8 liters per mil
            Vehicle motorcycle = new Motorcycles { Name = "Yamaha", FuelConsumption = 0.5 };        // 0.5 liters per mil

            car.CalculateEfficiency();      // Output: "BMW kan köra 12.5 mil på 10 liter bränsle."
            motorcycle.CalculateEfficiency();   // Output: "Yamaha kan köra 20 mil på 10 liter bränsle."

            Console.ReadLine();
        }
    }
}
