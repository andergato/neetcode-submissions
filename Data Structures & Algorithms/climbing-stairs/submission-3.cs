public class Solution {
    int[] cache;
    public int ClimbStairs(int n) {   
         cache = new int[n];
        for(int i = 0; i < n; i++){
            cache[i] = -1;
        }
        return fib(0, n);
    }

    public int fib(int i, int n) {
        if(i == n){
            return 1;
        }
        if(i > n){
            return 0;
        }
        if(cache[i] != -1){
            return cache[i];
        }
        int l1 = fib(i+1, n);
        int l2 = fib(i+2, n);

        cache[i] = l1 + l2;
        return cache[i];
    }
}
