namespace LibraryForLab9
{
    public class Duck
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Duck(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Quack()
        {
            return $"{Name} quack.";
        }

        public string Eat()
        {
            return $"{Name} eating.";
        }
    }
}