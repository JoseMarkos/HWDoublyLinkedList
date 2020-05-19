using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerable : IEnumerable<Node>
    {
        private ListEnumerator ListEnumerator;
        public List List {get; private set;}

        public ListEnumerable (List list) {
            List = list;
            ListEnumerator = new ListEnumerator(List);
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return ListEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
