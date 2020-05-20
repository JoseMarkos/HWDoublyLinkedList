using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Insert
{
    public interface InsertRequirements
    {
        void InsertFirst(Node newNode, ref Node current);
        void InsertLast(Node newNode, ref Node current);
        void InsertAfterFirst(Node newNode, ref Node current); // If the list is empty not do it
        void InsertBeforeLast(Node newNode, ref Node current); // If the list is empty not do it
    }
}
