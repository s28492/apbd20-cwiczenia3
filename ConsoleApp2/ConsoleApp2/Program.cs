// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

ContainerShip ship1 = new ContainerShip();
ContainerShip ship2 = new ContainerShip();

LiquidContainer liquidContainer = new LiquidContainer(1,2,3,4,true);
GazContainer gazContainer = new GazContainer(1,2,3,4,134);
RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(1,2,3,4,"Bananas", 140);
RefrigeratedContainer refrigeratedContainer2 = new RefrigeratedContainer(1,2,3,4,"Chocolate", 18);
RefrigeratedContainer refrigeratedContainer3 = new RefrigeratedContainer(1,2,3,4,"Eggs", 19);
List<Container> containersList = new List<Container>();
containersList.Add(gazContainer);
containersList.Add(refrigeratedContainer2);
refrigeratedContainer.ContainerInfo();

ship1.LoadContainer(liquidContainer);
ship1.ShipInfo();
ship1.RemoveContainer(liquidContainer);
ship1.ShipInfo();
ship1.LoadContainer(liquidContainer);
ship1.MoveContainer(ship2, liquidContainer);
ship1.ShipInfo();
ship2.ShipInfo();