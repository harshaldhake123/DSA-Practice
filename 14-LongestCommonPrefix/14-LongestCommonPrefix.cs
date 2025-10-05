// Last updated: 10/5/2025, 9:01:00 PM
public class TrieNode{
    public Dictionary<char,TrieNode> children=new Dictionary<char,TrieNode>();
    public bool isEndOfWord;
}

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0) return string.Empty;
        //fill up the trie
        var root=new TrieNode();
        foreach(var s in strs){
            if(string.IsNullOrEmpty(s)) return string.Empty;
            AddWordToTrie(root,s);
        }
        // traverse the tree, the moment either a node is end of word, or the trie splits is the end of loop. 
        var current=root;
        var longest=string.Empty;
        while(current.children.Count==1){
            var childChar=current.children.Keys.First();
            var childNode=current.children[childChar];
            
            if(childNode.isEndOfWord){
                longest+=childChar;
                return longest;
            }
            longest+=childChar;
            current=current.children[childChar];
        }
        return longest;
    }
    
    private void AddWordToTrie(TrieNode node,string str){
        foreach(var c in str){
            if(!node.children.ContainsKey(c)){
                node.children.Add(c,new TrieNode());
            }
            node = node.children[c];
        }
        node.isEndOfWord=true;
    }

    public string LongestCommonPrefixBrute(string[] strs) {
        var result=string.Empty;
        if (strs.Length == 0) return result;

        // Select the first(or any random) string for prefix comparison
        var first=strs[0];

        for(int i=0;i<first.Length;i++){
            var c=first[i];    
            // Compare current char with all other strings for that position
            foreach(var s in strs){
                if(i==s.Length || s[i]!=c){
                    return result; // Mismatch or end of string reached, so longest prefix can't exceed the min length string element
                }
            }    
            // If all strings have the char at the position, add char to result
            result+=c;
        }
        return result;
    }
}