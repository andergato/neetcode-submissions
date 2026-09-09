class DynamicArray(capacity: Int) {
    
    private var arr: IntArray
    private var size: Int = 0
    private var capacity: Int = capacity

    init {
        this.arr = IntArray(this.capacity)
    }

    fun get(i: Int): Int {
        return this.arr[i]
    }

    fun set(i: Int, n: Int) {
        arr[i] = n
    }

    fun pushback(n: Int) {
        if(this.size == this.capacity){
            resize()
        }
        arr[this.size] = n
        size++
    }

    fun popback(): Int {
        if(size > 0){
            size--
        }
        return arr[size]
    }

    private fun resize() {
        this.capacity = capacity * 2
        val newArr: IntArray = IntArray(this.capacity)

        for(i in 0..<this.size){
            newArr[i] = this.arr[i]
        }

        arr = newArr
    }

    fun getSize(): Int {
        return this.size
    }

    fun getCapacity(): Int {
        return this.capacity
    }
}
