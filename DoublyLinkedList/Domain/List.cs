using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List : IEnumerable<Node>
    {
        public Node Head;
        public Node Tail;
        public static int Count {get; private set;}

        public List () {
            Head = new Node();
            Count = 0;
        }

        public void InsertFirst(int data)
        {
            unsafe 
            {
                Count++;
                
                Node NewNode = new Node();
                NewNode.Data = data;
                Node* NewNodeLink = &NewNode;

                fixed(Node* HeadLink = &Head) {
                    NewNode.Next = HeadLink;
                    Node* PrevLink = HeadLink;
                    PrevLink = NewNodeLink;
                }
            }
        }

        // Beta
        private void SetLast(Node node) {
            //unsafe {
            //    Node indirect = (Node)Head;
    
            //    // while(indirect.Next != null)
            //    //     indirect = (*indirect.Next);

            //    indirect.Next = &node;
            //    Tail = node;

            //    node.Prev = &indirect;
            //}
        }

        public int GetCout() {
            return Count;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
