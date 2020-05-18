using System;
using HWDoublyLinkedList.Node.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Domain;

namespace HWDoublyLinkedList.Node.Application.Insert 
{
    public sealed class InsertNode : InsertRequirements
    {
        private List List;

        public InsertNode(List list)
        {
            List = list;
        }

        public void InsertAfterFirst(LinkedListNode node)
        {
            List.Head.Next = node;
        }

        public void InsertBeforeLast(LinkedListNode node)
        {
            throw new NotImplementedException();
        }

        public void InsertFirst(LinkedListNode node)
        {
            List.Head = node;
        }

        public void InsertLast(LinkedListNode node)
        {
            throw new NotImplementedException();
        }
    }
}