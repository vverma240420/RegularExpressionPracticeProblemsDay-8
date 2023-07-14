using System.Text.RegularExpressions;

namespace RegularExpressionPracticeProblemsDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "foxes are omnivorous mammals belonging to several genera\r\nof the family Canidae fox.";
            string str2 = "fox";
            int freq = Regex.Matches(str1, str2.ToString()).Count();
            Console.WriteLine(freq);

        }
    }
}