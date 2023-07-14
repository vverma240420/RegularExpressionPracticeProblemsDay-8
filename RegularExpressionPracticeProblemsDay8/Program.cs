using System.Text.RegularExpressions;

namespace RegularExpressionPracticeProblemsDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            string pattern = @"<[^>]+>";                                                  //<-matches the opening
            Regex regex = new Regex(pattern);                                             // [^>] - matches one or more occurences
            MatchCollection matches = regex.Matches(input);                               
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}