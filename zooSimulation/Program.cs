using System;
abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }

    public abstract void sound();

}

class Dog : Animal
{
    public Dog(string name, int age) 
    {
        Name = name;
        Age = age;
        Type = "Köpek";
    }
    public override void sound()
    {
        Console.WriteLine("Hav Hav!");
    }
}

class Bird : Animal
{
    public Bird(string name, int age)
    {
        Name = name; 
        Age = age;
        Type = "Kuş";
    }
    public override void sound()
    {
        Console.WriteLine("Cik cik!");
    }
}

class Cat : Animal
{
    public Cat(string name, int age)
    {
        Name = name;    
        Age = age;
        Type = "Kedi";
    }
    public override void sound()
    {
        Console.WriteLine("Meow Meow!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Melo",3);
        Bird bird = new Bird("Paşa",1);
        Cat cat = new Cat("Venüs", 5);


        Console.WriteLine($"{dog.Type} {dog.Name} isimli hayvan {dog.Age} yaşında.");
        dog.sound();
        Console.WriteLine($"{bird.Type} {bird.Name} isimli hayvan {bird.Age} yaşında.");
        bird.sound();
        Console.WriteLine($"{cat.Type} {cat.Name} isimli hayvan {cat.Age} yaşında.");
        cat.sound();

    }
}