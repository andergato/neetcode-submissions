public class Solution {
    public bool IsValid(string s) {
        if(s.Length < 2){
            return false;
        }
        Dictionary<char,char> dict = new Dictionary<char, char>{
            {'}','{'},{')','('},{']','['}
            };
        Stack<char> p = new Stack<char>();
        p.Push(s[0]);
        for(int i = 1; i < s.Length; i++){
            if(dict.ContainsValue(s[i])){
                p.Push(s[i]);
                continue;
            }
            p.TryPeek(out char value);
            if(value == dict[s[i]]){
                p.Pop();
                continue;
            }
            p.Push(s[i]);
        }
        return (p.Count == 0);
    }
}
