namespace Plastic_fantastic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreditCard card1 = new CreditCard("4027 3324 2344 2212", 10000);
            Console.WriteLine(card1);
            CreditCard card2 = new CreditCard("4353 3324 2344 2212", "Visa");

            Console.WriteLine(card2);

            CreditCard card3 = new CreditCard("4773 3324 1245 7722", "Visa", 2000);
            Console.WriteLine(card3);



        }
    }
}