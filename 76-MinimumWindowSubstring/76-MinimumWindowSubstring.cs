// Last updated: 9/12/2025, 11:57:12 PM
public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) return string.Empty;
        
        // Map to store the frequency of chars needed from t.
        var tFreq = new Dictionary<char, int>();
        // Map to store the frequency of chars in the current sliding window.
        var window = new Dictionary<char, int>();

        foreach (var c in t) {
            if (tFreq.ContainsKey(c)) tFreq[c]++; 
            else tFreq.Add(c, 1);
        }
        
        // left     : left pointer for the sliding window
        // minLength: stores the minimum window length found so far
        // have     : count of unique chars in the current window that match tFreq
        // need     : count of unique chars required from t.
        int left = 0, minLength = int.MaxValue, have = 0, need = tFreq.Count;
        var result = (-1, -1); //left and right substring indices

        // loop using right pointer to expand the sliding window.
        for (int right = 0; right < s.Length; right++) {
            var c = s[right];
            
            // Add the current char to the window frequency map.
            if (window.ContainsKey(c)) window[c]++;
            else window.Add(c, 1);
            
            // Check if the current char is a required one and if its count in the window
            // just satisfied the required frequency as per t.
            if (tFreq.ContainsKey(c) && window[c] == tFreq[c]) {
                have++; // Increment 'have' because we have now matched one unique char.
            }

            // This loop is to shrink the window from the left. It runs as long as the current
            // window is valid (i.e.still contains all chars from t with the required frequency).
            while (have == need) {
                // Calculate the length of the current valid window.
                var len = right - left + 1;
                
                // If this window is smaller than the smallest found so far,
                // update the minimum length and result indices.
                if (len < minLength) {
                    minLength = len;
                    result = (left, right);
                }
                
                // Get the char at the 'left' pointer before shrinking.
                char leftChar = s[left];

                // Reduce the leftmost char from the window's frequency count.
                window[leftChar]--;

                // If the char we just removed was a required one and its frequency
                // in the window is now < required frequency, we no longer have a valid window.
                if (tFreq.ContainsKey(leftChar) && window[leftChar] < tFreq[leftChar]) {
                    // Decrement have to note that the window is no longer valid,
                    // the right will move forward in the main loop may make the new window valid again
                    have--; 
                }
                // Move the left pointer ahead to shrink the window.
                left++;
            }
        }
        
        // If minLength is still int max, it means no valid window was ever found.
        // Otherwise, extract and return the substring
        return minLength < int.MaxValue 
            ? s.Substring(result.Item1, minLength) 
            : string.Empty;
    }
}
