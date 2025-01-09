using System.Text.RegularExpressions;
namespace Regex_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my phone number is 123-456-7890";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found:\nIn {text}");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"Found a {hit.Value} at index {group[0].Index}");
            }
        }
    }
}
