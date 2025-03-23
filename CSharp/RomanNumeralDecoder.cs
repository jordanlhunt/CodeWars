using System;
using System.Collections.Generic;

public class RomanDecode
{
    public static int Solution(string roman)
    {
        int returnValue = 0;
        Dictionary<char, int> romanNumeralDictionary = new Dictionary<char, int>();
        // Setup Dictionary
        romanNumeralDictionary.Add('I', 1);
        romanNumeralDictionary.Add('V', 5);
        romanNumeralDictionary.Add('X', 10);
        romanNumeralDictionary.Add('L', 50);
        romanNumeralDictionary.Add('C', 100);
        romanNumeralDictionary.Add('D', 500);
        romanNumeralDictionary.Add('M', 1000);


        for (int i = 0; i < roman.Length; i++)
        {
            if (romanNumeralDictionary.ContainsKey(roman[i]))
            {
                if (i + 1 < roman.Length)
                {
                    if (romanNumeralDictionary[roman[i + 1]] > romanNumeralDictionary[roman[i]])
                    {
                        returnValue = returnValue + (romanNumeralDictionary[roman[i + 1]] - romanNumeralDictionary[roman[i]]);
                        i++;
                    }
                    else
                    {
                        returnValue = returnValue + romanNumeralDictionary[roman[i]];
                    }
                }
                else
                {
                    returnValue = returnValue + romanNumeralDictionary[roman[i]];
                }
            }
        }
        return returnValue;
    }
}