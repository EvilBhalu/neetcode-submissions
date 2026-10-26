public class TrieNode()
{
    public Dictionary<char, TrieNode> Children = new();
    public bool IsEnd;
}

public class WordDictionary {

    private readonly TrieNode root;

    public WordDictionary() 
    {
        root = new TrieNode();    
    }
    
    public void AddWord(string word) 
    {
        var node = root;

        foreach(var c in word)
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
        return Helper(root, word, 0);
    }

    private bool Helper(TrieNode node, string word, int pos)
    {
        //base case
        if (pos == word.Length)
        {
            return node.IsEnd;
        }

        var letter = word[pos];

        if (letter != '.')
        {
            if (!node.Children.TryGetValue(letter, out var next))
            {
                return false;
            }

            return Helper(next, word, pos+1);
        }
        else
        {
            foreach(var child in node.Children.Values)
            {
                if (Helper(child, word, pos+1))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
