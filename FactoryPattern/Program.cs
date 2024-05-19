namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number of doors so I can guess what you're doing with your vehicle:");

            var numberOfDoors = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(numberOfDoors);

            vehicle.Drive();
        }
    }
}
