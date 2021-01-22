using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string chnInput = "";
        bool isPangram = true;
        input = input.ToLower();
        input = input.Trim();
        for (int i = 0; i < input.Length; i++)
        {
            if ((int)input[i] >= 97 && (int)input[i] <= 122) // is it letter?
            {
                chnInput += input[i];
            }
        }
        
        int[] lettersOcc = new int[26]; // counter for 25 letters of ascii alphabet
        for (int i = 0; i < chnInput.Length; i++)
        {
            
                lettersOcc[(int)chnInput[i] - 97] += 1; //add 1 for every occurence of letter to corresponding field of lettersOccArray(expl. acc of 'a' stored under index 0 )
           
           
        }
        for (int i = 0; i < lettersOcc.Length; i++) // check if every letter occured exactly one time.
        {
            if(lettersOcc[i] ==0)
            {
                isPangram = false;
            }
        }
        return isPangram;
    }
}
