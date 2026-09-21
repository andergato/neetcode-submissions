public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach(var s in strs){
            int[] count = new int[26];

            foreach(char c in s){
                count[c - 'a']++;
            }
            string list = string.Join(",", count);

            if(!res.ContainsKey(list)){
                res[list] = new List<string>();
            }
            res[list].Add(s);
        }
        
        var val = new List<List<string>>();
        foreach(var s in res){
            val.Add(s.Value);
        }
        return val;
    }
}
