namespace ConsoleApp2;

                                                                                                                                                                                                         
public class RefrigeratedContainer: Container, IHazardNotifier                                                                                                                                           
{                                                                                                                                                                                                        
    public string ProductType { get; set; }                                                                                                                                                              
    public double Temperature { get; set; }                                                                                                                                                              
    private Dictionary<string, double> productTemperatures = new Dictionary<string, double>();                                                                                                           
    public RefrigeratedContainer(double height, double containerWeight, double depth, double maxLoad, string productType, double temperature)                                      
        : base(height, containerWeight, depth, maxLoad, "C")                                                                                                                                   
    {                                                                                                                                                                                                    
        ProductType = productType;                                                                                                                                                                       
        productTemperatures.Add("Bananas", 13.3);                                                                                                                                                        
        productTemperatures.Add("Chocolate", 18);                                                                                                                                                        
        productTemperatures.Add("Fish", 2);                                                                                                                                                              
        productTemperatures.Add("Meat", -15);                                                                                                                                                            
        productTemperatures.Add("Ice cream", -18);                                                                                                                                                       
        productTemperatures.Add("Frozen pizza", -30);                                                                                                                                                    
        productTemperatures.Add("Cheese", 7.2);                                                                                                                                                          
        productTemperatures.Add("Sausages", 5);                                                                                                                                                          
        productTemperatures.Add("Butter", 20.5);                                                                                                                                                         
        productTemperatures.Add("Eggs", 19);                                                                                                                                                             
        Temperature = temperature;                                                                                                                                                                       
        CheckTemperature();                                                                                                                                                                              
    }

    public void ContainerInfo()
    {
        base.ContainerInfo();
        Console.WriteLine($"Product type: {ProductType}, product temperature: {productTemperatures[ProductType]}");
    }
    public override void Load(double mass)                                                                                                                                                               
    {                                                                                                                                                                                                   
        if (mass > MaxLoad)                                                                                                                                                                              
        {                                                                                                                                                                                                
            throw new OverfillException($"Cannot load {mass} kg into the refrigerated container. Exceeds maximum allowed mass.");                                                                        
        }                                                                                                                                                                                                
                                                                                                                                                                                                         
        LoadMass = mass;                                                                                                                                                                                 
    }                                                                                                                                                                                                    
                                                                                                                                                                                                         
    public override void Unload()                                                                                                                                                                        
    {                                                                                                                                                                                                    
        LoadMass = 0;                                                                                                                                                                                    
    }                                                                                                                                                                                                    
                                                                                                                                                                                                         
    public void CheckTemperature()                                                                                                                                                                       
    {                                                                                                                                                                                                    
        if (Temperature < productTemperatures[ProductType])                                                                                                                                              
        {                                                                                                                                                                                                
            throw new ArgumentException(                                                                                                                                                                 
                $"The temperature set for product {ProductType} cannot be lower than {productTemperatures[ProductType]}");                                                                               
        }                                                                                                                                                                                                
    }                                                                                                                                                                                                    
                                                                                                                                                                                                         
    public void NotifyHazard(string message)                                                                                                                                                             
    {                                                                                                                                                                                                    
        Console.WriteLine($"Hazard Notification for {SerialNumber}: {message}");                                                                                                                         
    }                                                                                                                                                                                                    
}                                                                                                                                                                                                        