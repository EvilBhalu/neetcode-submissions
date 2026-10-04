public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> l1 = new List<List<string>>();
        Dictionary<string, List<string>> d1 = new Dictionary<string, List<string>>();

        if (strs == null)
            return null;

        foreach(var str in strs)
        {
            var sarr = str.ToCharArray();
            Array.Sort(sarr);

            var key = new string(sarr);

            if(!d1.ContainsKey(key))
            {
                d1[key] = new List<string>();
            }
            
            d1[key].Add(str);
        }

        return new List<List<string>>(d1.Values);
    }
}
