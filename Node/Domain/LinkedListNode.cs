using System;

namespace HWDoublyLinkedList.Node.Domain
{
    public sealed class LinkedListNode
    {
        public string Data {get; set;}
        public LinkedListNode Prev {get; set;}
        public LinkedListNode Next {get; set;}
    }
}
