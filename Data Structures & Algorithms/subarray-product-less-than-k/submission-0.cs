public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) 
    {
        int l=0, best=0;
        int product=1;

        for (int r=0; r<nums.Length; r++)
        {
            // add n[r]
            product *= nums[r];

            //validity check
            while (product >= k && l<=r)
            {
                product /= nums[l];
                l++;
            }

            //update best
            best += r-l+1;
            Console.WriteLine($"best={best}, r={r}, l={l}");
        }

        return best;    
    }
}