using LibraryForLab9;

class Program
{
    static void Main(string[] args)
    {
        Farm farm = new();

        farm.AddDuck(new Duck("Rob", "Black"));
        farm.AddDuck(new Duck("RubDuck", "Yellow"));

        foreach (var duck in farm.GetDucks())
        {
            Console.WriteLine($"Duck name is {duck.Name} and this duck {duck.Color}. {duck.Quack()} {duck.Eat()}");
        }
    }
}