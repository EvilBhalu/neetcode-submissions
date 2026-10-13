public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        Dictionary<char, int> magDict = new();
        foreach(var ch in magazine.ToCharArray())
        {
            if(!magDict.ContainsKey(ch))
            {
                magDict.Add(ch, 1);
            }
            else
            {
                magDict[ch]++;
            }
        }

        foreach(var ch in ransomNote.ToCharArray())
        {
            if (!magDict.ContainsKey(ch))
                return false;

            else
            {
                magDict[ch]--;
                if (magDict[ch] < 0)
                    return false;
            }
        }

        return true;
    }
}