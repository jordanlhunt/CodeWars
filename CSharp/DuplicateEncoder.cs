using System.Collections.Generic;
public class Kata
{
    public static string DuplicateEncode(string word)
    {
        string upperCaseInput = word.ToUpper();
        Dictionary<char, int> characterCountDictionary = new Dictionary<char, int>();
        string result = "";
        foreach (char character in upperCaseInput)
        {
            if (characterCountDictionary.ContainsKey(character))
            {
                characterCountDictionary[character] += 1;
            }
            else
            {
                characterCountDictionary.Add(character, 1);
            }
        }
        for (int i = 0; i < upperCaseInput.Length; i++)
        {
            if (characterCountDictionary[upperCaseInput[i]] == 1)
            {
                result += "(";
            }
            else
            {
                result += ")";
            }
        }
        return result;
    }
}