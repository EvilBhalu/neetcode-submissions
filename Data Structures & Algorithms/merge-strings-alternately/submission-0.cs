public class Solution {
    public string MergeAlternately(string word1, string word2) 
    {
        StringBuilder sb = new();

        var l1 = word1.Length;
        var l2 = word2.Length;
        
        int i=0, j=0;
        while ((i < l1) || (j < l2))
        {
            if (i < l1)
            {
                sb.Append(word1[i]);
                i++;
            }
            if (j < l2)
            {
                sb.Append(word2[j]);
                j++;
            }
        }
        return sb.ToString();
    }
}