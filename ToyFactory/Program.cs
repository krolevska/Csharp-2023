using System;
using System.Collections.Generic;

public abstract class Toy
{
    private int minAge;
    public string Name { get; set; }
    public decimal Price { get; set; }
    public virtual int MinAge
    {
        get { return minAge; }
        protected set { minAge = value; }
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{GetType().Name}: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine();
    }
}

public class SoftToy : Toy
{
    public SoftToy()
    {
        MinAge = 0;
    }
}

public class Puzzle : Toy
{
    public Puzzle()
    {
        MinAge = 12;
    }
}

public class AdultToy : Toy
{
    public AdultToy()
    {
        MinAge = 18;
    }
}

public abstract class ToyFactory
{
    public abstract List<Toy> CreateToys();
}

public class SoftToyFactory : ToyFactory
{
    public override List<Toy> CreateToys()
    {
        return new List<Toy>
        {
            new SoftToy { Name = "Teddy Bear", Price = 10.0m },
            new SoftToy { Name = "Bunny", Price = 12.0m }
        };
    }
}

public class PuzzleFactory : ToyFactory
{
    public override List<Toy> CreateToys()
    {
        return new List<Toy>
        {
            new Puzzle { Name = "Jigsaw Puzzle", Price = 15.0m },
            new Puzzle { Name = "Crossword", Price = 10.0m }
        };
    }
}

public class AdultToyFactory : ToyFactory
{
    public override List<Toy> CreateToys()
    {
        return new List<Toy>
        {
            new AdultToy { Name = "Butt Plug", Price = 20.0m },
            new AdultToy { Name = "Clitoral Vibrator", Price = 25.0m }
        };
    }
}

public class Person
{
    public decimal Money { get; set; }
    public int Age { get; set; }
    public Toy Toy { get; set; }

    public void BuyToy(Toy toy)
    {
        if (Money >= toy.Price && Age >= toy.MinAge)
        {
            Money -= toy.Price;
            Console.WriteLine("Toy purchased successfully.");
        }
        else
        {
            Console.WriteLine("You cannot buy this toy.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var softToyFactory = new SoftToyFactory();
        var softToys = softToyFactory.CreateToys();

        var puzzleFactory = new PuzzleFactory();
        var puzzles = puzzleFactory.CreateToys();

        var adultToyFactory = new AdultToyFactory();
        var adultToys = adultToyFactory.CreateToys();

        var toys = new List<Toy>();
        toys.AddRange(softToys);
        toys.AddRange(puzzles);
        toys.AddRange(adultToys);

        Console.WriteLine("Available toys:");
        foreach (var toy in toys)
        {
            toy.DisplayInfo();
        }

        var person = new Person();
        Console.WriteLine("Please specify the toy name: ");
        string toyName = Console.ReadLine();
        Console.WriteLine("How old are you: ");
        int personAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your budget: ");
        decimal personMoney = Convert.ToDecimal(Console.ReadLine());

        person.Age = personAge;
        person.Money = personMoney;
        person.Toy = toys.Find(t => t.Name == toyName);

        person.BuyToy(person.Toy);
    }
}
