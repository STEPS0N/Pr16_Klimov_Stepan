using System.Text.RegularExpressions;

namespace Submission_of_Applications_Klimov.RegexС
{
    public class Check
    {
        public static bool CheckReg(string input, string need)
        {
            Match m = Regex.Match(input, need);
            return m.Success;
        }
    }
}
