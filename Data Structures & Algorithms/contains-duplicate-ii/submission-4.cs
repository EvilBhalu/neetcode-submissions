public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        // BRUTE FORCE
        // for(int i=0; i<nums.Length-1; i++)
        // {
        //     for (int j=i+1; j<nums.Length; j++)
        //     {
        //         if (nums[i] == nums[j])
        //         {
        //             if (Math.Abs(i-j) <= k)
        //                 return true;
        //         }
        //     }
        // }
        // return false;

        Dictionary<int, int> myDict = new();
        for(int i=0; i<nums.Length; i++)
        {
            if(!myDict.ContainsKey(nums[i]))
            {
                myDict.Add(nums[i], i);
            }
            else
            {
                if ((i - myDict[nums[i]]) <= k)
                {
                    return true;
                }
                else
                {
                    myDict[nums[i]] = i;
                }
            }
        }

        return false;
    }
}