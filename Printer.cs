using System;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.Node.Domain;

namespace HWDoublyLinkedList 
{
    sealed class Printer {
        public static void Print(DoublyList list)
        {

            IEnumerator<LinkedListNode> enumerator = list.GetEnumerator();
            System.Console.WriteLine(list.Count + " List count \n");

            for (int i = list.Count; i > 1; i--)
            {
                enumerator.MoveNext();
                unsafe
                {
                    System.Console.WriteLine(enumerator.Current.Data + " eee current");
                }
                System.Console.WriteLine(enumerator.Current.Data + " eee current");
            }
                
            System.Console.WriteLine(list.Count + " List count \n");
        }
    }
}