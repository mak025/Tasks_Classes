namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to checkif its a palindrome");
            string word = Console.ReadLine();
            Console.WriteLine(CheckPalindrome(word));
        }
        public static bool CheckPalindrome(string word)
        {
            Stack<char> chars = new Stack<char>();
            foreach (char letter in word)
            {
                chars.Push(letter);
            }
            foreach(char letter in word)
            {
                if (letter != chars.Pop())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
