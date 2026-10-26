public class TrieNode
{
    public Dictionary<char, TrieNode> Children = new();
    public bool IsEnd;
}

public class PrefixTree {

    private readonly TrieNode root;

    public PrefixTree() 
    {
        root = new TrieNode();
    }
    
    public void Insert(string word) 
    {
        var node = root;

        foreach(char c in word)
        {
            if (!node.Children.TryGetValue(c, out var next))
            {
                next = new TrieNode();
                node.Children[c] = next;
            }
            node = next;
        }
        
        node.IsEnd = true;
    }
    
    public bool Search(string word) 
    {
        var node = root;

        foreach(char c in word)
        {
            if (!node.Children.TryGetValue(c, out var next))
            {
                return false;
            }
            node = next;
        }

        return node.IsEnd;
    }
    
    public bool StartsWith(string prefix) 
    {
        var node = root;

        foreach(char c in prefix)
        {
            if (!node.Children.TryGetValue(c, out var next))
            {
                return false;
            }
            node = next;
        }

        return true;
    }
}
