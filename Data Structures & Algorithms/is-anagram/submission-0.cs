public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        Dictionary<char, int> anaDict1 = new Dictionary<char, int>();
        Dictionary<char, int> anaDict2 = new Dictionary<char, int>();

        foreach(var c in s.ToCharArray())
        {
            if (anaDict1.ContainsKey(c))
            {
                anaDict1[c]++;
            }
            else
            {
                anaDict1.Add(c, 1);
            }
        }

        foreach(var c in t.ToCharArray())
        {
            if (anaDict2.ContainsKey(c))
            {
                anaDict2[c]++;

            }
            else
            {
                anaDict2.Add(c, 1);
            }
        }

        if (anaDict1.Count != anaDict2.Count)
            return false;

        foreach (var key in anaDict1.Keys)
        {
            if(!anaDict2.ContainsKey(key))
            {
                return false;
            }

            if(anaDict2[key] != anaDict1[key])
            {
                return false;
            }
        }

        return true;
    }
}
