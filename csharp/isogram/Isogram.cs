using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        bool isIsogram = true;
        List<char> chars = new List<char>();
        for (int i = 0; i < word.Length; i++)
        {
            if ((int)word[i] >= 97 && (int)word[i] <= 122) // is it letter?)
            {
                if (chars.Contains(word[i])) // does list of chars contain this?
                {
                    isIsogram = false; //its already in list - not isogram
                }
                else
                {
                    chars.Add(word[i]); // not already in list = add there
                }
            }

            
        }
        return isIsogram;
    }
}
