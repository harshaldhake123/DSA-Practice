// Last updated: 9/24/2025, 10:46:05 PM
public class TrieNode{
    public Dictionary<char,TrieNode> children=new Dictionary<char,TrieNode>();
    public bool isEnd=false;
}
public class WordDictionary {
    private readonly TrieNode root;
    public WordDictionary() {
        root=new TrieNode();
    }
    
    public void AddWord(string word) {
        var current=root;
        foreach(var c in word){
            if(!current.children.ContainsKey(c)){
                current.children.Add(c,new TrieNode());
            }
            current=current.children[c];
        }
        current.isEnd=true;
    }
    
    public bool Search(string word) {
       return Search(word, 0, this.root);
    }

    private bool Search(string word,int i, TrieNode root){
        if(i==word.Length){
            return root.isEnd;
        }
        var current=root;
        var c = word[i];
        if(c =='.'){
            foreach(var child in current.children.Values){
                if(this.Search(word,i+1, child)){
                    return true;
                }
            }
            return false;
        }else{
            if(!current.children.ContainsKey(c)){
                return false;
            }
            return Search(word, i+1, current.children[c]);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */