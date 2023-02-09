public class Dog
{
    public string Name;

    public Dog(string name)
    {
        this.Name = name;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} Barked");
    }
}