using System;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;

namespace HWDoublyLinkedList 
{
    sealed class Printer {
        public static void Print(DoublyList list)
        {

            IEnumerator<int> enumerator = list.GetEnumerator();
            System.Console.WriteLine(list.Count + " List count \n");

            for (int i = list.Count; i > 0; i--)
            {
                enumerator.MoveNext();
                System.Console.WriteLine(enumerator.Current + " eee current");
                System.Console.WriteLine(enumerator.Current + " eee current");
            }
                
            System.Console.WriteLine(list.Count + " List count \n");
        }
    }
}