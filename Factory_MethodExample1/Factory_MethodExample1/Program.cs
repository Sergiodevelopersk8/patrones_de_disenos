
using Factory_MethodExample1;
using Factory_MethodExample1.Factories;

bool ciclo = true;
Console.WriteLine("Bienvenido factoria ejemplo");

VehicleFactory vehicleFactory = null;

while (ciclo)
{
    Console.WriteLine("Elige el tipo de vehiculo 1) car, 2) Motocicleta, 3) Bike, 4) Quit");
    int VehicleChoice = Convert.ToInt32(Console.ReadLine());
    switch (VehicleChoice)
    {

        case 1:
            vehicleFactory = new CarFactory();
            break;

        case 2:
            vehicleFactory = new MotorcycleFactory();
            break;

        case 3:
            vehicleFactory = new BikeFactory();
            break;

        case 4:
          ciclo = false;
            break;
    }
    IVehicle vehicle = vehicleFactory.OrderVehicle();
    Console.WriteLine($"Elegiste {vehicle.GetType().Name}.\n");

}

Console.WriteLine("Gracias por usar nuestro sistema SMC DEV SK8");
Console.ReadKey();
