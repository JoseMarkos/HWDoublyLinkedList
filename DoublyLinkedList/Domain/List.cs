using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using System.Collections.Generic;
using System.Collections;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List : ICollection
    {
        private List<Node> innerCol;
        public unsafe Node Head;
        public Node Tail;
        public unsafe Node* CurrentLink;
        public int Count {get; private set;}

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public List () {
            Count = 0;
            innerCol = new List<Node>();
            unsafe {
                fixed (Node* HeadLink  = &Head) {
                    innerCol.Add(*HeadLink);
                }
            }
        }

        public void InsertFirst(int data)
        {
            unsafe 
            {
                Node NewNode = new Node();
                NewNode.Data = data;
                Node* NewNodeLink = &NewNode;

                if(innerCol.Count > 1) 
                {

                    innerCol.Add(*NewNodeLink);
                     
                }

                innerCol.Add(*NewNodeLink);



                System.Console.WriteLine(Head.Data  + " head data pointer");
                System.Console.WriteLine((*NewNodeLink).Data  + " head data pointer");
                Count++;
            }
        }

        public int GetCout() {
            return Count;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return new ListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator(this);
        }
    }
}
