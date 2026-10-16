public class Solution {
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int l=0, best=int.MaxValue;
        int sum=0;

        for (int r=0; r<nums.Length; r++)
        {
            // add r
            sum += nums[r];

            // validity check
            while (sum >= target)
            {
                // update?
                best = Math.Min(best, r-l+1);

                sum -= nums[l];
                l++;
            }
        }

        return best == int.MaxValue ? 0 : best;    
    }
}