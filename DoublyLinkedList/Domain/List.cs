using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using System.Collections.Generic;
using System.Collections;
using HWDoublyLinkedList.DoublyLinkedList.Application.Insert;
using HWDoublyLinkedList.DoublyLinkedList.Application.Delete;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List : InsertRequirements, DeleteRequirements, IEnumerable<Node>, ICollection<Node>
    {
        public  Node Mooc {get; private set;}
        public  Node Head {get; private set;}
        public Node Tail {get; private set;}
        public int Count {get; private set;}
        private ListEnumerator ListEnumerator = null;
        private ListReverseEnumerator ListReverseEnumerator = null;

        public bool IsSynchronized => false;

        public object SyncRoot => null;

        public bool IsReadOnly => throw new NotImplementedException();

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
            if (Contains(newNode))
            {
                throw new InvalidOperationException("The item already exsits");
            }

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
                throw new ArgumentOutOfRangeException("The list has no elements");
            }

            if (Contains(newNode))
            {
                throw new InvalidOperationException("The item already exsits");
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
            if (Contains(newNode))
            {
                throw new InvalidOperationException("The item already exsits");
            }

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
                throw new ArgumentOutOfRangeException("The list has no elements");
            }

            if (Contains(newNode))
            {
                throw new InvalidOperationException("The item already exsits");
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
                throw new ArgumentOutOfRangeException("The list has no elements");
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

            Count--;
        }

        public void DeleteLast()
        {
            if (Head is null)
            {
                throw new ArgumentOutOfRangeException("The list has no elements");
            }

            Count--;
            Tail = Tail.Prev;

            if (Tail is null)
            {
                Head = null;
                Mooc.Next = Head;
            }
            else 
            {
                Tail.Next = null;
            }
        }

        public void DeleteAfterFirst()
        {
            if (Head is null)
            {
                throw new ArgumentOutOfRangeException("The list has no elements");
            }

            if (Head.Next is null)
            {
                throw new ArgumentOutOfRangeException("The element is out of range");
            }

            Count--;
            // two childs case
            if (Head.Next.Next is null) 
            {
                Head.Next = null;
                Tail = Head;
                return;
            }
            // three+ childs clase
            Node indirect = new Node(Head.Next.Next.Data);
            indirect.Prev = Head;
            indirect.Next = Head.Next.Next.Next;
            Head.Next = indirect;
        }

        public void DeleteBiggest()
        {
            if (Head is null)
            {
                throw new ArgumentOutOfRangeException("The list has no elements");
            }

            IEnumerator<Node> enumerator = GetEnumerator();
            enumerator.MoveNext();
            int biggest = enumerator.Current.Data;
            int GetMax(int x, int current) => x > current? x : current;

            while(enumerator.MoveNext())
            {
                biggest = GetMax(biggest, enumerator.Current.Data);
            }
        }

        public void Clear()
        {
            Count   = 0;
            Mooc    = new Node(0);
            Head    = null;
            Tail    = null;
        }

        public void Add(Node item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Node item)
        {
            IEnumerator<Node> enumerator = GetEnumerator();

            while(enumerator.MoveNext())
            {
                if (enumerator.Current.Data == item.Data)
                {
                    enumerator.Dispose();
                    return true;
                }
            }

            enumerator.Dispose();
            return false;
        }

        public void CopyTo(Node[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Node item)
        {
            throw new NotImplementedException();
        }
    }
}
