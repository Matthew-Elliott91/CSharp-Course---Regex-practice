using System.Text.RegularExpressions;
namespace Regex_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void ExtractPatterns(string input)
            {
                
                Regex regex = new Regex(@"(support|sales)@example\.(com|org)");
                MatchCollection matchCollection = regex.Matches(input);

                foreach (Match match in matchCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
            ExtractPatterns("Contact us at support@example.com or sales@example.org.");

        //    Console.WriteLine("Hello, World!");
        //    string pattern = @"\d";
        //    Regex regex = new Regex(pattern);

        //    string text = "Hi there, my phone number is 123-456-7890";

        //    MatchCollection matchCollection = regex.Matches(text);

        //    Console.WriteLine($"{matchCollection.Count} hits found:\nIn {text}");

        //    foreach (Match hit in matchCollection)
        //    {
        //        GroupCollection group = hit.Groups;
        //        Console.WriteLine($"Found a {hit.Value} at index {group[0].Index}");
        //    }
        //
        }
    }
}
