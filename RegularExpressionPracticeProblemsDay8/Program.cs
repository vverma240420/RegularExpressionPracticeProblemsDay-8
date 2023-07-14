using System.Text.RegularExpressions;

namespace RegularExpressionPracticeProblemsDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string pattern = @"ab{2,3}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine("Input string matches the pattern!");
            }
            else
            {
                Console.WriteLine("Input string does not match the pattern.");
            }
        }
    }
}