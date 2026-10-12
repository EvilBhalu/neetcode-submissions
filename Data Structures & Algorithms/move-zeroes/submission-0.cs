public class Solution {
    public void MoveZeroes(int[] nums) 
    {
        int next=0;

        for(int i=0; i<nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[i];
                nums[i] = nums[next];
                nums[next] = temp;
                next++;
            }
        }
    }
}