public class Solution {
    public int[] FindBuildings(int[] heights) {
        var s = new Stack<int>();
        s.Push(0);
        for(int i = 1; i < heights.Length; i++){
            while(s.Count > 0 && heights[i] >= heights[s.Peek()]){
                s.TryPop(out int item);
            }
            s.Push(i);
        }
        int[] res = new int[s.Count];
        for(int i = s.Count - 1; i >= 0; i--){
            res[i] = s.Pop();
        }
        return res;
    }
}