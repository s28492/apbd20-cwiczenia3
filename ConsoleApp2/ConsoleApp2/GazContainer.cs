namespace ConsoleApp2;

                                                                                                                                                   
public class GazContainer: Container, IHazardNotifier                                                                                              
{                                                                                                                                                  
    public double CurrentPressure { get; set; }                                                                                                    
    public GazContainer(double height, double containerWeight, double depth, double maxLoad, double currentPressure)                               
        : base(height, containerWeight, depth, maxLoad, "G")                                                                                       
    {                                                                                                                                              
        CurrentPressure = currentPressure;                                                                                                         
    }

    public void ContainerInfo()
    {
        base.ContainerInfo();
        Console.WriteLine($"Pressure: {CurrentPressure}");
    }

    public override void Load(double mass)                                                                                                        
 {                                                                                                                                                 
     if (mass > MaxLoad)                                                                                                                           
     {                                                                                                                                             
         throw new OverfillException($"The load you are trying to put into is too much for this container");                                       
     }                                                                                                                                             
     LoadMass = mass;                                                                                                                              
                                                                                                                                                   
 }                                                                                                                                                 
                                                                                                                                                   
     public override void Unload()                                                                                                                 
     {                                                                                                                                             
         LoadMass = LoadMass*0.05;                                                                                                                 
     }                                                                                                                                             
                                                                                                                                                   
    public void NotifyHazard(string message)                                                                                                       
    {                                                                                                                                              
        Console.WriteLine($"Hazard Notification for {SerialNumber}: {message}");                                                                   
    }                                                                                                                                              
                                                                                                                                                   
}                                                                                                                                                  