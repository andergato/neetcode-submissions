class ListNode(
    var value: Int,
    var next: ListNode? = null
)

class LinkedList {
    private var head: ListNode = ListNode(-1)
    private var tail: ListNode = head

    fun get(index: Int): Int {
        var curr = head.next
        var i = 0
        while(curr != null) {
            if(i == index){
                return curr.value
            }
            i++
            curr = curr.next
        }
        return -1
    }

    fun insertHead(value: Int) {
        var newNode: ListNode = ListNode(value)
        newNode.next = head.next
        head.next = newNode
        if(newNode.next == null){
            tail = newNode
        }
    }

    fun insertTail(value: Int) {
        var newNode: ListNode = ListNode(value)
        tail.next = newNode
        tail = newNode
    }

    fun remove(index: Int): Boolean {
        var curr = head
        var nextNode = curr.next
        var i = 0
        while(nextNode != null){
            if(i == index){
                if(nextNode == tail){
                    tail = curr
                }
                curr.next = nextNode.next
                return true
            }
            i++
            curr = curr.next !!
            nextNode = nextNode.next
        }
        return false
    }

    fun getValues(): List<Int> {
        val list = mutableListOf<Int>()
        var curr = head.next
        while(curr != null){
            list.add(curr.value)
            curr = curr.next
        }
        return list
    }
}
