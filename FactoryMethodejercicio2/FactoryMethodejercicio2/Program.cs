using FactoryMethodejercicio2;
using FactoryMethodejercicio2.Factories;

Console.WriteLine("Bienvenido a el modulo de notificación");

bool inicio = true;
while (inicio)
{
    Console.WriteLine("\nPorfavor elija un tipo de notificación : (1) Email, (2) SMS, (3) Push, (4) Quitar");
    int elegido = int.Parse(Console.ReadLine());
    NotificationFactory factory = null;

    switch (elegido)
    {
        case 1: 
            factory = new EmailNotificationFactory(); 
            break;
        case 2:
            factory = new SmsNotificationFactory();
            break;
        case 3:
            factory = new PushNotificationFactory();
            break;
        case 4:
            inicio = false;
            break;
    }

    try
    {
        INotification notificacion = factory.CreateNotification();
        Console.WriteLine("Por favor ingrese un mensaje ");
        string mensaje = Console.ReadLine();
        notificacion.send(mensaje);

    }

    catch (Exception error) {
    
        Console.WriteLine(error.ToString());
    
    }

}