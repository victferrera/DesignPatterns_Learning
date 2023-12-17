// See https://aka.ms/new-console-template for more information
using DesignPatterns_Learning.FactoryMethod;
using DesignPatterns_Learning.FactoryMethod.Transportation;

// loop the options

bool keepAlive = true;

do
{
    Console.Clear();

    try
    {
        Console.WriteLine("Select one option:");
        Console.WriteLine("The option selected will show a test of the design pattern");
        Console.WriteLine();
        Console.WriteLine("1 - Factory Method");
        Console.WriteLine("20 - Exit");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                TestFactoryMethod();
                break;
            case 20:
                Environment.Exit(0);
                break;
            default: throw new ArgumentException("Invalid option");
        }

    }
    catch(FormatException)
    {
        Console.Clear();
        Console.WriteLine("Input isn't in a valid format, try again...");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        continue;
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex.Message);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        continue;
    }

} while (keepAlive);

#region FactoryMethod
void TestFactoryMethod()
{
    Console.Clear();
    Console.WriteLine("Factory Method");

    Factory factory = new ConcreteTransportFactory();
    ITransport typeA = factory.ProduceRoadTransport();
    ITransport typeB = factory.ProduceSeaTransport();

    ExecuteDelivery(typeA);
    ExecuteDelivery(typeB);

    Console.WriteLine("Press any key to proceed");
    Console.ReadKey();
}

void ExecuteDelivery(ITransport transport)
{
    Console.WriteLine("I don't know what kind of transportation I'm using, but I know that this transport type has a way to deliver things");
    Console.WriteLine($"Delivery type: {transport.Deliver()}");
}

#endregion