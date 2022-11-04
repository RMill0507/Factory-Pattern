namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfSeats;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of seat availability for the vehicle you want to make:");

                input = int.TryParse(Console.ReadLine(), out numberOfSeats);
            } while (input == false);

           var vehicle = VehicleFactory.GetVehicle(numberOfSeats);
            vehicle.Drive();

            
        
        }
    }
}
