using System;

namespace ConsoleApp;

public class Human
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Coffee OrderCoffee(CoffeeType coffees)
    {
        switch (coffees)
        {
            case CoffeeType.Nescafe:
                return new Coffee();
            case CoffeeType.Lipton:
                return new Coffee();
            default:
                throw new ArgumentException("Invalid coffee type.");
        }
    }

    public void Drink(Coffee coffee)
    {
        return;
    }
    public enum CoffeeType
    {
        Nescafe,
        Lipton
    }
}
