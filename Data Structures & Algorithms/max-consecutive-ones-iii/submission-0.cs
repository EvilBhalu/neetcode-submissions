public class Solution {
    public int LongestOnes(int[] nums, int k) 
    {
        int l=0, best=0;
        List<int> myL = new();

        for (int r=0; r<nums.Length; r++)
        {
            myL.Add(nums[r]);
            if (nums[r] == 0)
            {
                k--;
            }

            while (k < 0)
            {
                myL.Remove(nums[l]);
                if (nums[l] == 0)
                {
                    k++;
                }
                l++;
            }

            best = Math.Max(best, myL.Count());
        }

        return best;
    }
}