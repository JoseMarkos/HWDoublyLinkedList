using System;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using System.Collections.Generic;

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

            DoublyList doublyList = new DoublyList(list);

            Printer.Print(doublyList);

        }
    }
}