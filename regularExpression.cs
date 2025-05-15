using System.Text.RegularExpressions;

public class Solution {
    public bool IsMatch(string s, string p) {
        Regex regex = new Regex(@"^" + p + @"$");
        Match match = regex.Match(s);

        if(match.Success)
        {
            return true;
        }

        else return false;
    }
}
