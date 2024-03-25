namespace ConsoleApp2;
public abstract class Container
{
    public double LoadMass { get; protected set; }
    public double Height { get; set; }
    public double ContainerWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; }
    private static int _serialCounter = 0;
    public double MaxLoad { get; set; }

    public Container(double height, double containerWeight, double depth, double maxLoad, string containerType)
    {
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        MaxLoad = maxLoad;
        SerialNumber = GenerateSerialNumber(containerType);
    }

    private static string GenerateSerialNumber(string containerType)
    {
   
        return $"KON-{containerType}-{_serialCounter++}";
    }

    public void ContainerInfo()
    {
            Console.WriteLine($"Container Serial Number: {SerialNumber}, Heigth: {Height}, Weigth: {ContainerWeight}, Depth: {Depth}, Max load: {MaxLoad}");
    }

    public abstract void Load(double mass);
    public abstract void Unload();
}
public class OverfillException : Exception
{
    public OverfillException(string theLoadYouAreTryingToPutIntoIsTooMuchForThisContainer)
    {
        Console.WriteLine("Cannot fill this container with so much stuff");
    }
}                                                                                                                                                        