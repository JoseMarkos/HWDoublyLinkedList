using System;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList 
{
    sealed class Printer {
        public static void Print(List list)
        {
            IEnumerator<Node> enumerator = list.GetEnumerator();

            for (int i = list.Count; i > 0; i--)
            {
                enumerator.MoveNext();
                System.Console.WriteLine(enumerator.Current.Data + " current");
            }
        }
    }
}