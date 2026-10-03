public class Solution {
    public int Search(int[] nums, int target) {
        
        int l=0;
        int r=nums.Length/2;

        if (l == r)
        {
            if (nums[l] == target)
                return 0;
            else
                return -1;
        }

        while (l <= r)
        {
            if (target == nums[r])
                return r;

            if (target == nums[l])
                return l;

            if (target < nums[r])
            {
                r = r-1;
                continue;
            }

            if (target > nums [r])
            {
                l = r+1;
                r = nums.Length - 1;
                continue;
            }
        }

        return -1;
    }
}
