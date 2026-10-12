public class Solution {
    public int[] SortedSquares(int[] nums) 
    {
        // Non optimal solution
        // for(int i=0; i<nums.Length; i++)
        // {
        //     nums[i] *= nums[i];
        // }
        // Array.Sort(nums);
        // return nums;

        int n = nums.Length;
        int[] res = new int[n];
        int l=0, r=n-1, index=n-1;

        while (l <= r)
        {
            var v1 = nums[l] * nums[l];
            var v2 = nums[r] * nums[r];

            if (v1 < v2)
            {
                res[index] = v2;
                r--;
            }
            else
            {
                res[index] = v1;
                l++;
            }

            index--;
        }

        return res;
    }
}