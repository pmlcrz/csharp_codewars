public class Kata
{
    public static string[] AddLength(string str)
    {
        string[] words = str.Split(' ');
        string[] result = new string[words.Length];
        
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            int length = word.Length;
            result[i] = $"{word} {length}";
        }
        
        return result; 
    }
}
