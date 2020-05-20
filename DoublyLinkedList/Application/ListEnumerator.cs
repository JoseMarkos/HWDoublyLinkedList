using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerator : IEnumerator<Node>
    {
        private List source;

        public List GetSource()
        {
            return source;
        }

        private void SetSource(List value)
        {
            source = value;
        }

        private Node _current;

        public static int Count {get; private set;}

        public ListEnumerator(Node node) {
            _current = node;
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
                if (_current.Next != null)
                {
                   _current = _current.Next;
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
