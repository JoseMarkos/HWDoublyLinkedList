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
        private Node noteReseted;

        public static int Count {get; private set;}

        public ListEnumerator(Node node) {
            _current = node;
            noteReseted = node;
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
            _current = noteReseted;
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
            throw new NotImplementedException();
        }
    }
}
