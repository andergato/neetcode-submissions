public class Solution {
    public bool IsValid(string s) {
        var res = new Stack<char>();

        if(s.Length < 2 || (s[0] == ')') || (s[0] == ']') || (s[0] == '}')){
            return false;
        }

        foreach(char c in s){
            if(c == '{' || c == '(' || c == '[' ){
                res.Push(c);
            }
            else if(res.Count() < 1){
                res.Push(c);
            }
                else if((res.Peek() == '{' && c == '}')
                     || (res.Peek() == '(' && c == ')')
                     || (res.Peek() == '[' && c == ']')
                     ){
                    res.Pop();
                }
                else{
                    res.Push(c);
                }
        }

        if(res.Count() == 0){
                return true;
            }
            else{
                return false;
            }
    }
}
