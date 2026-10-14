using System;

public class Bird : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Flapping wings");
    }
}

public class Airplane : Vehicle, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Jet engines");
    }
}

public class Superman : SuperHero, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Up, up and away");
    }
}

public class ElectricCar : Vehicle, IChargeable
{
    public void Charge()
    {
        Console.WriteLine("Charging electric car");
    }
}

public class Phone : Device, IChargeable
{
    public void Charge()
    {
        Console.WriteLine("Charging phone");
    }
}

public class RobotVacuum : Appliance, IChargeable
{
    public void Charge()
    {
        Console.WriteLine("Charging robot vacuum");
    }
}
