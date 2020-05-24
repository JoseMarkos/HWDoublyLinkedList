using System;

namespace HWDoublyLinkedList.DoublyLinkedNode.Domain
{
    public class Node
    {
        public int Data;
        public  Node Prev;
        public  Node Next;

        public Node(int info)
        {
            Data = info;
        }
    }
}
