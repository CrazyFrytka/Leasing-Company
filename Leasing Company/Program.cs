
namespace Leasing_Company;
public class AllVehicleStorage
{
    List<CargoVehicles> AllCargoVehicles;
    List<PassengerVehicles> AllPassengerVehicles;

    public AllVehicleStorage()
    {
        AllCargoVehicles = new List<CargoVehicles>();
        AllPassengerVehicles = new List<PassengerVehicles>();
    }

    public void NewPassengerVehicle(PassengerVehicles passengerVehicle)
    {
        Console.WriteLine("Add new vehicle");
        AllPassengerVehicles.Add(passengerVehicle);
    }
    public void NewCargoVehicle(CargoVehicles cargoVehicle)
    {
        Console.WriteLine("Add new vehicle");
        AllCargoVehicles.Add(cargoVehicle);
    }
    public List<PassengerVehicles> ShowAllPassengerVehicles()
    {
        return AllPassengerVehicles;
    }
    public List<CargoVehicles> ShowAllCargoVehicles()
    {
        return AllCargoVehicles;
    }
}

class Program
{
    static void AddNewVehicle(AllVehicleStorage storage)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Brand: ");
        string brand = Console.ReadLine();
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("Year of Manufacture: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Color: ");
        string color = Console.ReadLine();
        Console.Write("Price: ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Registration Number: ");
        int registrationNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 1 to add new passenger vehicle, 2 to add new cargo vehicle: ");

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                PassengerVehicles newPassengerVehicle = new PassengerVehicles(id, brand, model, year, color, price, registrationNumber)
                {
                    ID = id,
                    Brand = brand,
                    Model = model,
                    YearOfManufacture = year,
                    Color = color,
                    Price = price,
                    RegistrationNumber = registrationNumber
                };
                storage.NewPassengerVehicle(newPassengerVehicle);
                break;
            case "2":
                CargoVehicles newCargoVehicle = new CargoVehicles(id, brand, model, year, color, price, registrationNumber)
                {
                    ID = id,
                    Brand = brand,
                    Model = model,
                    YearOfManufacture = year,
                    Color = color,
                    Price = price,
                    RegistrationNumber = registrationNumber
                };
                storage.NewCargoVehicle(newCargoVehicle);
                break;
            default:
                Console.WriteLine("Invalid  option");
                break;
        }
    }

    static void Main()
    {
        AllVehicleStorage vehicleStorage = new AllVehicleStorage();
        do
        {
            Console.WriteLine("Enter 1 to add a new vehicle, 2 to show  all passenger vehicles, 3 to show all cargo vehicles ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddNewVehicle(vehicleStorage);
                    break;

                case "2":
                    List<PassengerVehicles> allPassengerVehicles = vehicleStorage.ShowAllPassengerVehicles();
                    Console.WriteLine("All passenger vehicles:");
                    foreach (var vehicle in allPassengerVehicles)
                    {
                        Console.WriteLine($"ID: {vehicle.ID}, Brand: {vehicle.Brand}, Model: {vehicle.Model}, Year: {vehicle.YearOfManufacture}, Color: {vehicle.Color}, Price: {vehicle.Price}, Registration Number: {vehicle.RegistrationNumber}");
                    }
                    break;
                case "3":
                    List<CargoVehicles> allCargoVehicles = vehicleStorage.ShowAllCargoVehicles();
                    Console.WriteLine("All cargo vehicles: ");
                    foreach (var vehicle in allCargoVehicles)
                    {
                        Console.WriteLine($"ID: {vehicle.ID}, Brand: {vehicle.Brand}, Model: {vehicle.Model}, Year: {vehicle.YearOfManufacture}, Color: {vehicle.Color}, Price: {vehicle.Price}, Registration Number: {vehicle.RegistrationNumber}");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

        } while (true);
    }
}
