using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using System.Collections.Generic;
using System.Collections;
using HWDoublyLinkedList.DoublyLinkedList.Application.Insert;
using HWDoublyLinkedList.DoublyLinkedList.Application.Delete;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List : InsertRequirements
    {
        public unsafe Node Mooc;
        public unsafe Node Head;
        public Node Tail;
        public int Count {get; private set;}

        public List () 
        {
            Count = 0;
            Mooc = new Node(0);
            Head = null;
            Tail = null;
        }

        public void InsertFirst(Node newNode)
        {
            if (Head != null) 
            {   
                newNode.Next = Head;
                newNode.Next.Prev = newNode;
            }

            Head = newNode; 
            Mooc.Next = Head;

            if (Tail is null) 
            {
                Tail = Head;
            }

            Count++;
        }
        
        public void InsertAfterFirst(Node newNode)
        {
            if (Head is null) {
                throw new IndexOutOfRangeException("The list has no elements");
            }

            bool SetTailFlag = false;

            if (Tail.Equals(Head))
            {
                SetTailFlag = true;
            }

            if (Head.Next != null)
            {
                Head.Next.Prev = newNode;
                newNode.Next = Head.Next;
            }

            newNode.Prev = Head;
            Head.Next = newNode;

            if (SetTailFlag) 
            {
                Tail = newNode;
            }

            Count++;
        }

        public void InsertLast(Node newNode) 
        {
            if (Head is null)
            {
                Head = newNode;
                Tail = newNode;

                return;
            }

            newNode.Prev = Tail;
            newNode.Prev.Next = newNode;        
            
            Tail = newNode;

            Count++;
        }

        public void InsertBeforeLast(Node newNode) {
            Count++;
        }

        public void DeleteAfterFirst()
        {
            Count--;
        }

        public void DeleteBiggest()
        {
            Count--;
            throw new NotImplementedException();
        }

        public void DeleteFirst()
        {
            Count--;
        }

        public void DeleteLast()
        {
            Count--;
        }
    }
}
