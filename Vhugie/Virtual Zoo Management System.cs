using System;
using System.Collections.Generic;



//CREATE A INTERNAL CLASS FOR ANIMAL
internal class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("Animal is sleeping...");
    }
}



//CREATE A CLASS
class Lion : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Lion is eating meat.");
    }

    public override void Sleep()
    {
        Console.WriteLine("Lion is sleeping in the shade.");
    }

    public void Roar()
    {
        Console.WriteLine("Lion is roaring!");
    }
}


//LIST THE ANIMAL
class Parrot : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Parrot is eating seeds.");
    }

    public override void Sleep()
    {
        Console.WriteLine("Parrot is sleeping on a perch.");
    }

    public void Speak()
    {
        Console.WriteLine("Parrot is mimicking human speech.");
    }
}


//LIST SECOND ANIMAL
class Turtle : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Turtle is eating lettuce.");
    }

    public override void Sleep()
    {
        Console.WriteLine("Turtle is sleeping underwater.");
    }

    public void Crawl()
    {
        Console.WriteLine("Turtle is crawling on the ground.");
    }
}



//INCLUDE BEHAVIOUR
interface IFeedable
{
    void Feed();
}


interface IMovable
{
    void Move();
}


class FeedingLion : Lion, IFeedable
{
    public void Feed()
    {
        Console.WriteLine("Feeding the lion...");
    }
}

class MovingParrot : Parrot, IMovable
{
    public void Move()
    {
        Console.WriteLine("Parrot is flying from branch to branch.");
    }
}

class Program
{
    static void Main()
    {
       
        Lion lion = new Lion();
        Parrot parrot = new Parrot();
        Turtle turtle = new Turtle();

       
        lion.Eat();
        parrot.Sleep();

        
        List<Animal> animals = new List<Animal> { new FeedingLion(), new MovingParrot() };

        foreach (var animal in animals)
        {
            if (animal is IFeedable feedable)
            {
                feedable.Feed();
            }
            if (animal is IMovable movable)
            {
                movable.Move();
            }
        }
    }
}
