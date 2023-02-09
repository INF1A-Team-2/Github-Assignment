public class Cat
{
    public string Name;
    public Cat(string name)
    {
        this.Name = name;
    }
    public void Meow()
    {
        Console.WriteLine($"Cat {Name} says meow");
    }
}
