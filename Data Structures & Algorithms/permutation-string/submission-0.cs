public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        var need = new Dictionary<char, int>();
        foreach(char c in s1)
        {
            need[c] = need.GetValueOrDefault(c) + 1;
        }

        int l=0;
        for (int r=0; r<s2.Length; r++)
        {
            // add n[r]
            Adjust(need, s2[r], -1);

            if (need.Count == 0)
                return true;

            // validity check
            while (need.Values.Any(v => v<0))
            {
                Adjust(need, s2[l], +1);
                l++;
            }

            // update
            // not needed here as we can return as soon as we find the answer
        }

        return false;
    }

    private void Adjust(Dictionary<char, int> d, char c, int delta)
    {
        int v = d.GetValueOrDefault(c) + delta;
        if (v == 0)
            d.Remove(c);
        else
            d[c] = v;
    }
}
