public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int l=0, r=0;

        for(l=0; l<nums.Length; l++)
        {
            if (nums[l] != nums[r])
            {
                r++;
                nums[r] = nums[l];
            }
        }

        return r+1;
    }
}