// Interface
using System;

interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
    void animaltype();
    void sleep();
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
    public void animaltype()
    {
        Console.WriteLine("The animal type : Mamifero");
    }

    public void sleep()
    {
        Console.WriteLine("zzz");
    }
}
class Burro : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The burro says: iiiiigg ooooooh");
    }
    public void animaltype()
    {
        Console.WriteLine("The animal type : Mamifero");
    }

    public void sleep()
    {
        Console.WriteLine("zzz");
    }
}
class Oso : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The oso says: Wraaaaaaorrrrrr");
    }
    public void animaltype()
    {
        Console.WriteLine("The animal type : Mamifero");
    }

    public void sleep()
    {
        Console.WriteLine("zzz");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();
        myPig.animaltype();
        myPig.sleep();

        Burro myBurro = new Burro();
        myBurro.animalSound();
        myBurro.animaltype();
        myBurro.sleep();

        Oso myoso = new Oso();
        myoso.animalSound();
        myoso.animaltype();
        myoso.sleep();
    }
}
