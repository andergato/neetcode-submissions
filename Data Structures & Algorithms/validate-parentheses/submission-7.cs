public class Solution {
    public bool IsValid(string s) {
        var parenthesis = new Dictionary<char,char>{
            [')'] = '(',
            ['}'] = '{',
            [']'] = '['
            };
        var stack = new Stack<char>();
        foreach(char c in s){
            if(stack.TryPeek(out char value) && parenthesis.ContainsKey(c)){
                if(parenthesis[c] == value){
                    stack.Pop();
                    continue;
                }
                stack.Push(c);
                continue;
            }
            stack.Push(c);
        }
        return (stack.Count == 0);
    }
}
