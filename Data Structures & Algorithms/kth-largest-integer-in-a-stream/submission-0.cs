public class KthLargest 
{
    List<int> myList = new();
    int pos = 0;

    public KthLargest(int k, int[] nums) 
    {
        pos = k;

        foreach(var v in nums)
        {
            myList.Add(v);
        }

        int n=myList.Count();
    }
    
    public int Add(int val) 
    {
        myList.Add(val);
        myList.Sort();
        int n=myList.Count();
        return myList[n-pos];
    }
}
