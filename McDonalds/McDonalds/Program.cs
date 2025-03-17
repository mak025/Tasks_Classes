namespace McDonalds
{
    /// <summary>
    /// A console program that simulates taking orders for a fast-food menu, including drinks, fries, and a burger.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point of the program that takes user input for drink, fries, and burger details to create a menu and calculates the total price.
        /// </summary>
        /// <param name="args">Command-line arguments (not used in this program).</param>
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Maccas Laddie!");
            Thread.Sleep(400);
            Console.WriteLine("Which drink would you like? (Cola, Fanta, Pepsi) my name is sexy");

            Console.ForegroundColor = ConsoleColor.White;
            string drinkName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose a drink size ya juice gobber! (Small, Medium, Large): ");
            Console.ForegroundColor = ConsoleColor.White;

            // Parse the user input to the DrinkSize enum, ignoring case sensitivity by passing true
            DrinkSize drinkSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), Console.ReadLine(), true);
            Drinks drink = new Drinks(drinkName, drinkSize);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Coolio my stinky dude! Which size of fries would ya like? Medium, Large, XLarge:");
            Console.ForegroundColor = ConsoleColor.White;

            // Parse the user input to the FriesSize enum, ignoring case sensitivity by passing true
            FriesSize friesSize = (FriesSize)Enum.Parse(typeof(FriesSize), Console.ReadLine(), true);
            Fries fries = new Fries(friesSize);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Noted. One batch of salty potato sticks coming up");
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Now what kind of burger does the calorie container want? (Cheeseburger, Hamburger or BaconCheeseBurger)");
            Console.ForegroundColor = ConsoleColor.White;

            // Parse the user input to the BurgerType enum, ignoring case sensitivity by passing true
            BurgerType burgerType = (BurgerType)Enum.Parse(typeof(BurgerType), Console.ReadLine(), true);
            Burger burger = new Burger(burgerType);

            // Create a Menu object using the selected items
            Menu menu = new Menu(drink, fries, burger);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You ordered a menu with: {menu}");
            Console.WriteLine($"Total price: {menu.GetTotalPrice()} kr.");
            Console.WriteLine($"You'll be looking like Jabba the Hutt in no time!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
