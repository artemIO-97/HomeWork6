namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Feed(FoodType.CatFood, 25);

        }
        public enum FoodType
        {
            PigFood,
            CatFood,
            Other
        }
    }
}