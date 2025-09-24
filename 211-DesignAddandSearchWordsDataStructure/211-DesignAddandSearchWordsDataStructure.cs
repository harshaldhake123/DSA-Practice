// Last updated: 9/24/2025, 10:52:39 PM
public class TrieNode{
    public TrieNode[] children=new TrieNode[26];
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
            var index=c-'a';
            if(current.children[index]==null){
                current.children[index]=new TrieNode();
            }
            current=current.children[index];
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
            foreach(var child in current.children){
                if(child!=null && this.Search(word,i+1, child)){
                    return true;
                }
            }
            return false;
        }else{
            var index=c-'a';
            if(current.children[index] ==null){
                return false;
            }
            return Search(word, i+1, current.children[index]);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */