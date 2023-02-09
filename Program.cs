public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog("Guus");
        Cat cat = new Cat("Pieter");
        Bird bird = new Bird("Joost");
        Snake snake = new Snake("Mirzad");

        dog.Bark();
        cat.Meow();
        bird.Chirp();
        snake.Hiss();
    }
}
