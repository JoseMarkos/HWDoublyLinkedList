using System;

namespace HWDoublyLinkedList.Node.Domain
{
    public struct LinkedListNode
    {
        public int Data;

        public unsafe LinkedListNode* Prev;
        public unsafe LinkedListNode* Next;
    }
}
