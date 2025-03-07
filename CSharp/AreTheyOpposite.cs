using System;

public class Kata
{
    public static bool IsOpposite(string s1, string s2)
    {
        bool myReturnValue = true;

        if (s1.Length == 0 || s2.Length == 0)
        {
            myReturnValue = false;
        }

        if ((s1.Length > 1 && s2.Length > 1))
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    myReturnValue = false;
                }
                else if (s1[i] != s2[i])
                {
                    char s1Upper = char.ToUpper(s1[i]);
                    char s2Upper = char.ToUpper(s2[i]);
                    if (s1Upper != s2Upper)
                    {
                        myReturnValue = false;
                    }
                }
            }

        }
        return myReturnValue;
    }
}