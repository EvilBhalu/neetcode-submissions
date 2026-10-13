public class NumArray {

    List<int> mylist = new();

    public NumArray(int[] nums) 
    {
        foreach(var num in nums)
        {
            mylist.Add(num);
        }    
    }
    
    public int SumRange(int left, int right) 
    {
        int sum = 0;
        for (int i=left; i<=right; i++)
        {
            sum += mylist[i];
        }    
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */