using System;

class Animal
{
    public virtual void makeSound() // virtual method returns the sound an animal makes
    {
        Console.WriteLine("The animal makes a generic sound.");
    }
}

class Dog : Animal
{
    private string breed;

    public Dog(string breed)
    {
        this.breed = breed;
    }

    //override method returns the sound a dog makes
    public override void makeSound()
    {
        Console.WriteLine("The " + breed + " dog says woof!");
    }
}

class Cat : Animal
{
    private string color;

    public Cat(string color)
    {
        this.color = color;
    }

    //override method returns the sound a cat makes
    public override void makeSound()
    {
        Console.WriteLine("The " + color + " cat says meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What kind of animal do you have? (dog/cat)");
        string animalType = Console.ReadLine();

        Animal myAnimal;

        if (animalType == "dog")
        {
            Console.WriteLine("What breed is your dog?");
            string breed = Console.ReadLine();
            myAnimal = new Dog(breed);
        }
        else if (animalType == "cat")
        {
            Console.WriteLine("What color is your cat?");
            string color = Console.ReadLine();
            myAnimal = new Cat(color);
        }
        else
        {
            Console.WriteLine("Sorry, idk how to make that animal sound");
            return;
        }

        myAnimal.makeSound();

        Console.ReadKey();
    }
}
