namespace Restaurant18
{
    public class MenuTableGenerator
    {
        public void ShowMenu(List<Menu> menus)
        {
            Console.WriteLine("--- Menu List---");
            foreach (var item in menus)
            {
                Console.WriteLine($"{item.Name}: {item.Price} yen");
            }
        }
    }
}