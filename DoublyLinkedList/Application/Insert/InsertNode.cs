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
            ListEnumerator enumerator = new ListEnumerator(current);

            Node indirect = current;

            while(enumerator.MoveNext()) 
            {
            }

            indirect = enumerator.Current;
            newNode.Prev = indirect.Prev; 
            newNode.Next = indirect;
            enumerator.Current.Prev = newNode;
        }

        public void InsertFirst(Node newNode, ref Node current)
        {
            newNode.Prev = current;
            Node indirect = current;
            
            if (indirect.Next != null) 
            {   
                newNode.Next = indirect.Next;
                indirect.Prev = newNode;
            }

            current.Next = newNode; 
        }

        public void InsertLast(Node newNode, ref Node current)
        {
            ListEnumerator enumerator = new ListEnumerator(current);
            Node last = new Node();

            while(enumerator.MoveNext()) 
            {
            }
            
            last = enumerator.Current;

            enumerator.Current.Next = newNode;
        }
    }
}