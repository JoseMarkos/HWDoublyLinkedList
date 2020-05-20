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


            Printer.Print(list);
        }
    }
}