public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] tower = new string[nFloors]; 
        
        for (int i = 0; i < nFloors; i++)
        {
            int spaceCount = nFloors - i - 1; 
            int asteriskCount = i * 2 + 1; 
            
            string floor = new string(' ', spaceCount) + new string('*', asteriskCount) + new string(' ', spaceCount);
            tower[i] = floor; 
        }
        
        return tower; 
    }
}
