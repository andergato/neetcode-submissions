public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

        var sDict = new Dictionary<char,int>();
        var tDict = new Dictionary<char,int>();

        for(int i = 0; i < s.Length; i++){
            sDict[s[i]] = sDict.GetValueOrDefault(s[i], 0) + 1;
            tDict[t[i]] = tDict.GetValueOrDefault(t[i], 0) + 1;
        }

        return (sDict.Count == tDict.Count) && !(sDict.Except(tDict).Any());
    }
}
