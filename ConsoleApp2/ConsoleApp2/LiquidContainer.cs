namespace ConsoleApp2;

                                                                                                                              
public class LiquidContainer : Container, IHazardNotifier                                                                     
{                                                                                                                             
    private bool IsDangerous { get; set; }                                                                                    
                                                                                                                              
    public LiquidContainer(double height, double containerWeight, double depth, double maxLoad, bool isDangerous)             
        : base(height, containerWeight, depth, maxLoad, "L")                                                                  
    {                                                                                                                         
        IsDangerous = isDangerous;                                                                                            
    }

    public void ContainerInfo()
    {
        base.ContainerInfo();
        Console.WriteLine($"Is dangerous: {IsDangerous}");
    }

    public override void Load(double mass)                                                                                    
    {                                                                                                                         
        double maxLoad = IsDangerous ? MaxLoad * 0.5 : MaxLoad * 0.9;                                                         
        if (mass > maxLoad)                                                                                                   
        {                                                                                                                     
            throw new OverfillException($"The load you are trying to put into is too much for this container");               
        }                                                                                                                     
        LoadMass = mass;                                                                                                      
                                                                                                                              
    }                                                                                                                         
                                                                                                                              
    public override void Unload()                                                                                             
    {                                                                                                                         
        LoadMass = 0;                                                                                                         
    }                                                                                                                         
                                                                                                                              
    public void NotifyHazard(string message)                                                                                  
    {                                                                                                                         
        Console.WriteLine($"Hazard Notification for {SerialNumber}: {message}");                                              
    }                                                                                                                         
}                                                                                                                             
                                                                                                                              