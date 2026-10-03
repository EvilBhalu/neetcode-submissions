public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        // for(int i=0; i<nums.Length; i++)
        // {
        //     int complement = target - nums[i];

        //     for(int j=0; j<nums.Length; j++)
        //     {
        //         if (nums[j] == complement)
        //         {
        //             return [i, j];
        //         }
        //     }
        // }

        // return [0,0];

        Dictionary <int, int> nums2 = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++)
        {
            int complement = target - nums[i];

            if (!nums2.ContainsKey(complement))
            {
                nums2[nums[i]] = i;
            }
            else
            {
                return[nums2[complement],i];
            }
        }

        return [0,0];
    }
}
