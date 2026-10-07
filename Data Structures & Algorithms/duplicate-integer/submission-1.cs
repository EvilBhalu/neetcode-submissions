public class Solution {
    public bool hasDuplicate(int[] nums) 
    {        
        List<int> names2 = new List<int>();

        foreach(var i in nums)
        {
            if (names2.Contains(i))
            {
                return true;
            }
            else
            {
                names2.Add(i);
            }
        }

        return false;
    }
}