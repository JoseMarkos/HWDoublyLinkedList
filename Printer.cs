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
            ListEnumerable enumerable = new ListEnumerable(list);

            IEnumerator<Node> enumerator = enumerable.GetEnumerator();

            for (int i = enumerable.List.Count; i > 0; i--)
            {
                System.Console.WriteLine("\n i " + i);
                enumerator.MoveNext();
                System.Console.WriteLine(enumerator.Current.Data + " eee current");
            }
                
            System.Console.WriteLine(enumerable.List.Count + " List count \n");
        }
    }
}