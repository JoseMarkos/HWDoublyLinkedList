using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Insert 
{
    public sealed class InsertNode : InsertRequirements
    {
        public void InsertAfterFirst(Node newNode, ref Node current)
        {
            if (current.Next.Next != null) 
            {
                Node indirect = current.Next.Next;
             
                newNode.Next = indirect;
                newNode.Prev = indirect.Prev;

                current.Next.Next = newNode;
                current.Next.Next.Next.Prev = newNode;

            }

            else {
                current.Next.Next = newNode;
                current.Next.Next.Prev = current.Next;
            }
        }

        public void InsertBeforeLast(Node newNode, ref Node current)
        {
            throw new NotImplementedException();
        }

        public void InsertFirst(Node newNode, ref Node current)
        {
            newNode.Prev = current;
            Node indirect = current;
            
            if (indirect.Next != null) 
            {
                newNode.Next = indirect.Next;
            }

            current.Next = newNode; 
        }

        public void InsertLast(Node newNode, ref Node current)
        {
            throw new NotImplementedException();
        }
    }
}