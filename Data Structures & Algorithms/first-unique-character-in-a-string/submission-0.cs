public class Solution {
    public int FirstUniqChar(string s) 
    {
        Dictionary<char, int> myDict = new();

        for (int i=0; i<s.Length; i++)
        {
            if (!myDict.ContainsKey(s[i]))
            {
                myDict.Add(s[i], 1);
            }
            else
            {
                myDict[s[i]]++;
            }
        }

        for (int i=0; i<s.Length; i++)
        {
            if (myDict[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}