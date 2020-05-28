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
            Node newNode = new Node(3);
            list.InsertFirst(newNode);
            Node newNode2 = new Node(2);
            list.InsertFirst(newNode2);
            Node newNode3 = new Node(1);
            list.InsertFirst(newNode3);

            List list2 = new List();
            Node newNode0 = new Node(3);
            list2.InsertFirst(newNode0);
            Node newNode02 = new Node(1);
            list2.InsertFirst(newNode02);
            Node newNode03 = new Node(2);
            list2.InsertAfterFirst(newNode03);

            List list3 = new List();
            Node newNode00 = new Node(1);
            list3.InsertFirst(newNode00);
            Node newNode002 = new Node(3);
            list3.InsertAfterFirst(newNode002);
            Node newNode003 = new Node(2);
            list3.InsertAfterFirst(newNode003);

            List list4 = new List();
            Node newNode000 = new Node(10);
            list4.InsertFirst(newNode000);
            Node myNode = new Node(20);
            list4.InsertLast(myNode);
            Node myOhterNode = new Node(5550);
            list4.InsertBeforeLast(myOhterNode);


            Node myOhterNode2 = new Node(9);
            list4.InsertBeforeLast(myOhterNode2);


            Printer.Print(list);
            System.Console.WriteLine("");
            Printer.Print(list2);
            System.Console.WriteLine("");
            Printer.Print(list3);
            System.Console.WriteLine("");
            Printer.Print(list4);
        }
    }
}