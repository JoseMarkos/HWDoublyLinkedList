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

        public void InsertAfterFirst(int data)
        {
            throw new NotImplementedException();
        }

        public void InsertBeforeLast(int data)
        {
            throw new NotImplementedException();
        }

        public void InsertFirst(int data)
        {
            
            throw new NotImplementedException();
            
        }

        public void InsertLast(int data)
        {
            throw new NotImplementedException();
        }
    }
}