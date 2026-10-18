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
    public int BatteryLevel { get; private set; } = 0;
    public void Charge()
    {
        Console.WriteLine("Charging electric car");
        BatteryLevel = 100;
    }
    public string ChargingStatus()
    {
        if (BatteryLevel < 20)
        {
            return "Empty";
        }
        else if (BatteryLevel < 50)
        {
            return "Low";
        }
        else
        {
            return "Ready";
        }
    }
}

public class Phone : Device, IChargeable
{
    public int BatteryLevel { get; private set; } = 0;
    public void Charge()
    {
        Console.WriteLine("Charging phone");
        BatteryLevel = 100;
    }
    public string ChargingStatus()
    {
        if (BatteryLevel < 15)
        {
            return "Empty";
        }
        else if (BatteryLevel < 40)
        {
            return "Low";
        }
        else
        {
            return "Ready";
        }
    }
}

public class RobotVacuum : Appliance, IChargeable
{
    public int BatteryLevel { get; private set; } = 0;
    public void Charge()
    {
        Console.WriteLine("Charging robot vacuum");
        BatteryLevel = 100;
    }
    public string ChargingStatus()
    {
        if (BatteryLevel < 5)
        {
            return "Empty";
        }
        else if (BatteryLevel < 20)
        {
            return "Low";
        }
        else
        {
            return "Ready";
        }
    }
}
