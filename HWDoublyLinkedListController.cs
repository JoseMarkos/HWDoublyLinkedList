using System;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList 
{
    public sealed class HWDoublyLinkedListController
    {
        public static void Show() 
        {
            List list = new List();
            Node newNode = new Node(1);
            list.InsertFirst(newNode);

            Node newNode2 = new Node(3);
            list.InsertAfterFirst(newNode2);

            Node newNode3 = new Node(2);
            list.InsertAfterFirst(newNode3);

            Printer.Print(list);
        }
    }
}