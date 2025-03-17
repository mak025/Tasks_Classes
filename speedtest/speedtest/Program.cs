using System;
using BlueBook;

namespace speedtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Pizza1", "Ham", "Mozerella", "Small", 12);
            Pizza pizza2 = new Pizza("Pizza2", "Mozzerella", "Parmesean", "Large", 10);
            Pizza pizza3 = new Pizza("Pizza3", "Turkey", "Onion", "Large", 9);

            Console.WriteLine(pizza1);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);


            Person carl = new Person("Carl", "48625678", "Carl@email.com", "814641548");
            Person james = new Person("James", "56874185", "James@email.com", "814644868");
            Person simon = new Person("Carl", "5618596", "Simon@email.com", "46848051448");

            Console.WriteLine(carl);
            Console.WriteLine(james);
            Console.WriteLine(simon);
        }
    }
}
