public class Solution {
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int, int> mydict = new();

        foreach(var num in nums)
        {
            if (!mydict.ContainsKey(num))
            {
                mydict.Add(num, 1);
            }
            else
            {
                mydict[num]++;
            }
        }

        foreach(var kvp in mydict)
        {
            if (kvp.Value > nums.Length/2)
                return kvp.Key;
        }    

        return 0;
    }
}