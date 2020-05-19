using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerator : IEnumerator<Node>
    {
        private List DoublyList;
        private Node Indirect;
        private Node _current;

        public static int Count {get; private set;}

        public ListEnumerator(List injectList) {
            DoublyList = injectList;
            _current = new Node();
        }

        public Node Current {
            get
            {
                unsafe {
                    Node hola = new Node();

                    if ((*DoublyList.Head.Next).Equals(hola))
                    {
                        return _current;
                    }

                    return _current;
                }
            }
        }

        object IEnumerator.Current {
            get { return 5; }
        } 

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            unsafe 
            {
                Node hola = new Node();

                if (!(DoublyList.Head).Equals(hola))
                {
                    fixed(Node* HeadLink = &DoublyList.Head){
                        Node* PrevLink = HeadLink;
                        
                        fixed(Node* CurrentLink = &_current) {
                            Node* other = CurrentLink;

                            other = (*PrevLink).Next;
                        }
    
                        System.Console.WriteLine((*PrevLink).Data);
                        System.Console.WriteLine("wth current " + (*PrevLink));
                    }

                    return true;
                }
            }
                
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
