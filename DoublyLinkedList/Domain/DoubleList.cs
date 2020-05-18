using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.Node.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class DoublyList {
        private List DoublyLinkedList;
        private ListEnumerator ListEnumerator;
        public int Count { get; set; }

        public DoublyList(List list)
        {
            DoublyLinkedList = list;
            ListEnumerator = new ListEnumerator(DoublyLinkedList);
            Count = DoublyLinkedList.GetCout();
        }

        public ListEnumerator GetEnumerator() => ListEnumerator;
    }

}