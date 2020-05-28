using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListReverseEnumerator : IEnumerator<Node>
    {
        private Node _current;
        private Node nodeReseted;

        public ListReverseEnumerator(IEnumerator<Node> enumerartor) 
        {
            while(enumerartor.MoveNext())
            {
            }

            Node Ghost = new Node(0);
            Ghost.Prev = enumerartor.Current;
            _current = Ghost;
            nodeReseted = Ghost;
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
            if (_current.Prev != null)
            {
                _current = _current.Prev;
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
