using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerator : IEnumerator<Node>
    {
        private Node _current;
        private Node nodeReseted;

        public ListEnumerator(Node node) {
            _current = node;
            nodeReseted = node;
        }

        public Node Current {
            get
            {
                return _current;
            }
        }

        object IEnumerator.Current {
            get { return this.Current; }
        }

        public void Dispose()
        {
            _current = nodeReseted;
        }

        public bool MoveNext()
        {
            if (_current.Next != null)
            {
                _current = _current.Next;
                return true;
            }
                
            return false;
        }

        public void Reset()
        {
            _current = nodeReseted;
        }
    }
}
