public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        // Solution 1
        // int maxL = 0;
        // List<char> temp = new();

        // for(int r=0; r<s.Length; r++)
        // {
        //     while(temp.Contains(s[r]))
        //     {
        //         temp.RemoveAt(0);
        //     }
        //     temp.Add(s[r]);
        //     maxL = Math.Max(temp.Count, maxL);
        // }

        int l=0, maxL = 0;
        HashSet<char> temp = new();
        
        for(int r=0; r<s.Length; r++)
        {
            while(temp.Contains(s[r]))
            {
                temp.Remove(s[l]);
                l++;
            }
            temp.Add(s[r]);
            maxL = Math.Max(r-l+1, maxL);   //this could also be temp.Count
        }
        
        return maxL;
    }
}
