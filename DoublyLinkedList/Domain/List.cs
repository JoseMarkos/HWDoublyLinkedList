using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using System.Collections.Generic;
using System.Collections;
using HWDoublyLinkedList.DoublyLinkedList.Application.Insert;
using HWDoublyLinkedList.DoublyLinkedList.Application.Delete;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List : InsertRequirements, DeleteRequirements, IEnumerable<Node>
    {
        public  Node Mooc;
        //private  Node Mooc;  
        public  Node Head {get; private set;}
        public Node Tail {get; private set;}
        public int Count {get; private set;}
        private ListEnumerator ListEnumerator;
        private ListReverseEnumerator ListReverseEnumerator;

        public List () 
        {
            Count = 0;
            Mooc = new Node(0);
            Head = null;
            Tail = null;
            ListEnumerator = new ListEnumerator(Mooc);
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
                Mooc.Next = Head;
                Count++;

                return;
            }

            newNode.Prev = Tail;
            newNode.Prev.Next = newNode;        
            
            Tail = newNode;
            Count++;
        }

        public void InsertBeforeLast(Node newNode) 
        {
            if (Head is null) {
                throw new IndexOutOfRangeException("The list has no elements");
            }

            if (Tail.Equals(Head))
            {
                newNode.Next = Tail;
                newNode.Next.Prev = newNode;
                
                Head = newNode;
                Mooc.Next = Head;
                Count++;

                return;
            }

            newNode.Next = Tail;
            newNode.Prev = Tail.Prev;
            newNode.Prev.Next = newNode;
            Tail.Prev = newNode;

            Count++;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return ListEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

         public IEnumerator<Node> GetReverseEnumerator()
        {
            ListReverseEnumerator = new ListReverseEnumerator(GetEnumerator());
            return ListReverseEnumerator;
        }

        public void DeleteFirst()
        {
            if (Head is null)
            {
                throw new IndexOutOfRangeException("The list has no elements");
            }
    
            Head = Head.Next;
            Mooc.Next = Head;
            
            if (Head is null)
            {
                Tail = null;
            }
            else
            {
                Head.Prev = null;
            }
        }

        public void DeleteLast()
        {
            throw new NotImplementedException();
        }

        public void DeleteAfterFirst()
        {
            throw new NotImplementedException();
        }

        public void DeleteBiggest()
        {
            throw new NotImplementedException();
        }
    }
}
