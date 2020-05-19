using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerator : IEnumerator<Node>
    {
        private List Source;
        private unsafe Node* Indirect;
        private Node _current;

        public static int Count {get; private set;}

        public ListEnumerator(List list) {
            _current = new Node();
            Source = list;
        }

        public Node Current {
            get
            {
                unsafe {
                    Node hola = new Node();
    
                    if ((hola).Equals(hola))
                    {
                        return _current;
                    }

                    return _current;
                }
            }
        }

        object IEnumerator.Current {
            get { return this.Current; }
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

                if (!(hola).Equals(hola))
                {
                   

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
