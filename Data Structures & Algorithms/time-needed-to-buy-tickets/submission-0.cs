public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) 
    {
        int front = 0;
        int count = 0;

        while (tickets[k] > 0)    
        {
            if (tickets[front] > 0)
            {
                tickets[front]--;
                count++;
            }

            if (tickets[k] == 0)
                return count;

            front++;
            if(front == tickets.Length)
                front = 0;
        }

        return count;
    }
}