public class Solution {
    public bool IsPalindrome(string s) 
    {
        //BRUTE FORCE?
        // StringBuilder sb = new StringBuilder();

        // foreach (char c in s)
        // {
        //     if (char.IsLetterOrDigit(c))
        //         sb.Append(c);
        // }

        // char[] arr = sb.ToString().ToLower().ToCharArray();
        // for(int i=0, j=arr.Length-1; i<arr.Length; i++, j--)
        // {
        //     if(arr[i] == arr[j])
        //         continue;
        //     else
        //         return false;
        // }

        // return true;


        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
                sb.Append(c);
        }
        char[] arr = sb.ToString().ToLower().ToCharArray();

        int l=0, r=sb.Length-1;
        while(l<r)
        {
            if (arr[l] != arr[r])
            {
                return false;
            }
            else
            {
                l++;
                r--;
            }
        }
        return true;
    }    
}
