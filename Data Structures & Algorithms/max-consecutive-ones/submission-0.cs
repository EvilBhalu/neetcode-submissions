public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int maxC = 0;
        int curC = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                curC++;
                maxC = Math.Max(curC, maxC);
            }
            else
            {
                curC = 0;
            }
        }
        return maxC;
    }
}