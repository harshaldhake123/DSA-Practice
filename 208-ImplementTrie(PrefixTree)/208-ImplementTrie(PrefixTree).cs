// Last updated: 9/24/2025, 10:13:00 PM
public class TrieNode{
    public Dictionary<char,TrieNode> children=new Dictionary<char,TrieNode>();
    public bool isEndOfWord=false;
}

public class Trie {
    public TrieNode root;
    public Trie() {
        root=new TrieNode();
    }
    
    public void Insert(string word) {
        var current=this.root;
        foreach(var c in word){
            if(!current.children.ContainsKey(c)){
                current.children.Add(c,new TrieNode());
            }
            current=current.children[c];
        }
        current.isEndOfWord=true;
    }
    
    public bool Search(string word) {
        var current=this.root;
        foreach(var c in word){
            if(!current.children.ContainsKey(c)){
                return false;
            }
            current=current.children[c];
        }
        return current.isEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var current=this.root;
        foreach(var c in prefix){
            if(!current.children.ContainsKey(c)){
                return false;
            }
            current=current.children[c];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */