public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        // Non template version
        // int l=0, r=0;

        // for(l=0; l<nums.Length; l++)
        // {
        //     if (nums[l] != nums[r])
        //     {
        //         r++;
        //         nums[r] = nums[l];
        //     }
        // }

        // return r+1;

        int write = 1;

        for (int read=1; read<nums.Length; read++)
        {
            if (nums[write-1] != nums[read])
            {
                nums[write] = nums[read];
                write++;
            }
        }

        return write;
    }
}