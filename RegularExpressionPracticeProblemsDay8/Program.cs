using System.Text.RegularExpressions;

namespace RegularExpressionPracticeProblemsDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
   
            string pattern = @"[a-z]+_[a-z]+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                Console.WriteLine("Sequences of lowercase letters joined by an underscore:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No sequences of lowercase letters joined by an underscore found.");
            }
            Console.ReadKey();
        }
    }
}