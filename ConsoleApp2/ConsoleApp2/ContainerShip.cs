namespace ConsoleApp2;

public class ContainerShip
{
    private Dictionary<string, Container> containers = new Dictionary<string, Container>();

    public ContainerShip()
    {
        
    }

    public void LoadContainer(Container container)
    {
        containers.Add(container.SerialNumber, container);
    }

    public void LoadContainers(List<Container> containersList)
    {
        foreach (var container in containersList)
        {
            LoadContainer(container);
        }
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container.SerialNumber);
    }

    public void ReplaceContainer(Container removeContainer, Container addContainer)
    {
        RemoveContainer(removeContainer);
        LoadContainer(addContainer);
    }

    public void MoveContainer(ContainerShip shipToMove, Container container)
    {
        RemoveContainer(container);
        shipToMove.LoadContainer(container);
    }

    public void ShipInfo()
    {
        Console.WriteLine("Ship is loaded with:");
        foreach (var container in containers.Values)
        {
            Console.WriteLine($"Container Serial Number: {container.SerialNumber}");
        }
    }

}