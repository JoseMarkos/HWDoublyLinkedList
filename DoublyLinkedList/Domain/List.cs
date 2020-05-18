using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.Node.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List
    {
        public LinkedListNode? Head;
        public LinkedListNode? Tail;
        public static int Count {get; private set;}

        public List () {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void InsertFirst(int data)
        {
            unsafe {
                LinkedListNode NewNode = new LinkedListNode();
                NewNode.Data = data;
                Count++;

                System.Console.WriteLine("insert first: " + NewNode.Data );

                if (Head is null ){
                    Head = NewNode;
                    Tail = NewNode;
                    return;
                }

                LinkedListNode HeadNode = (LinkedListNode)Head;

                NewNode.Next = HeadNode.Next;

                Head = NewNode;

                System.Console.WriteLine("insert first head data: " + ((LinkedListNode)Head).Data);
            }
        }

        // Beta
        private void SetLast(LinkedListNode node) {
            unsafe {
                LinkedListNode indirect = (LinkedListNode)Head;
    
                // while(indirect.Next != null)
                //     indirect = (*indirect.Next);

                indirect.Next = &node;
                Tail = node;

                node.Prev = &indirect;
            }
        }

        public int GetCout() {
            return Count;
        }
    }
}
