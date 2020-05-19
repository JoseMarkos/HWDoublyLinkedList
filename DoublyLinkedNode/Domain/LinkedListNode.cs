using System;

namespace HWDoublyLinkedList.DoublyLinkedNode.Domain
{
    public struct Node
    {
        public int Data;

        public unsafe Node* Prev;
        public unsafe Node* Next;
    }
}
