using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsovaiDatabase
{
    internal class Security
    {
        bool PasswordCheck(string pass)
        {
            char[] specialChars = { '@', '!', '#', '$', '%', '^', '&', '*' };
            if (pass.Length>=15)
            {
                if (pass.ContainsAny(specialChars))
                {
                    int sumOfDigits = pass.Where(char.IsDigit).Sum(c => c - '0');
                    if (sumOfDigits % 7 != 0)
                    {
                        return true;
                    }
                }
            }
            


            return false;
        }
    }


}


public static class Extensions
{
    public static bool ContainsAny(this string input, char[] characters)
    {
        foreach (char c in characters)
        {
            if (input.Contains(c))
                return true;
        }
        return false;
    }
}
