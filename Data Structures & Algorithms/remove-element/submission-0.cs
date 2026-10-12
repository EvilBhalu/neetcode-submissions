public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int l=0, r=0;

        while (l < nums.Length)
        {
            if (nums[l] != val)
            {
                nums[r] = nums[l];
                r++;
                l++;
            }
            else
            {
                l++;
            }
        }  

        return r;
    }
}