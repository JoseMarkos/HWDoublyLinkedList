using System;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;

namespace HWDoublyLinkedList 
{
    public sealed class HWDoublyLinkedListController
    {
        public static void Show() 
        {
            List list = new List();
            list.InsertFirst(3);
            list.InsertFirst(4);
            list.InsertFirst(5);
            list.InsertFirst(6);

            Printer.Print(list);
        }
    }
}