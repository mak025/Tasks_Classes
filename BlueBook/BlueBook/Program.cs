namespace BlueBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person carl = new Person("Carl", "Male", 32, "Steelworks", "craftsmanship");
            
            Console.WriteLine(carl);
        }
    }
}
