public class KthLargest 
{
    //List<int> myList = new();
    // int pos = 0;

    PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
    int pos = 0;

    public KthLargest(int k, int[] nums) 
    {
        // pos = k;
        // foreach(var v in nums)
        // {
        //     myList.Add(v);
        // }

        pos = k;
        foreach(var v in nums)
        {
            pq.Enqueue(v,v);
            if(pq.Count > k)
                pq.Dequeue();
        }
    }
    
    public int Add(int val) 
    {
        // myList.Add(val);
        // myList.Sort();
        // int n=myList.Count();
        // return myList[n-pos];

        pq.Enqueue(val, val);
        if(pq.Count > pos)
            pq.Dequeue();
        return pq.Peek();
    }
}
