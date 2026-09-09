// Definition for a pair
// class Pair(var key: Int, var value: String)

class Solution {
    fun insertionSort(pairs: MutableList<Pair>): List<List<Pair>> {
        var res = mutableListOf<List<Pair>>()
        val n = pairs.size
        for(i in 0..<n){
            var k = i - 1
            while(k >= 0 && (pairs[k].key > pairs[k+1].key)){
                val temp = pairs[k]
                pairs[k] = pairs[k+1]
                pairs[k+1] = temp
                k--
            }
            res.add(pairs.map{Pair(it.key,it.value)})
        }
        return res
    }
}