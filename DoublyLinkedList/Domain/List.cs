using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List  
    {
        public unsafe Node* Head;
        public Node Tail;
        public unsafe Node* CurrentLink;
        public int Count {get; private set;}

        public List () {
            Count = 0;
        }

        public void InsertFirst(int data)
        {
            unsafe 
            {
                Node NewNode = new Node();
                NewNode.Data = data;
                Node* NewNodeLink = &NewNode;
                
                if(Count > 1) {
                    (*NewNodeLink).Next = Head;    
                }

                Head = NewNodeLink;


                System.Console.WriteLine((*Head).Data  + " head data pointer");
                System.Console.WriteLine((*NewNodeLink).Data  + " head data pointer");
                Count++;
            }
        }

        public int GetCout() {
            return Count;
        }
    }
}
