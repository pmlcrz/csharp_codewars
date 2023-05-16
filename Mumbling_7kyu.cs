using System;

public class Accumul
{
    public static string Accum(string s)
    {
        string result = ""; 
        
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            
           
            result += char.ToUpper(currentChar) + new string(char.ToLower(currentChar), i) + "-";
        }
        
        result = result.TrimEnd('-'); 
        
        return result; 
    }
}
