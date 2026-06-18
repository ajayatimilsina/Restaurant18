namespace Restaurant18
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuList = new List<Menu>
            {
                new MainMenu("momo", 1000),
                new DrinkMenu("coffee", 300),
                new MainMenu("pizza", 2000),
                new DrinkMenu("juice", 500),
                new MainMenu("burger", 1500),
                new DrinkMenu("tea", 200),
                new MainMenu("pasta", 1800),
                new DrinkMenu("soda", 400),
                new MainMenu("salad", 1200),
                new DrinkMenu("water", 100)
            };

            var generator = new MenuTableGenerator();
            generator.ShowMenu(menuList);
        }
    }
}