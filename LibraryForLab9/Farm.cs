namespace LibraryForLab9
{
    public class Farm
    {
        private List<Duck> ducks = new List<Duck>();

        public void AddDuck(Duck duck)
        {
            ducks.Add(duck);
        }

        public List<Duck> GetDucks()
        {
            return ducks;
        }
    }
}
