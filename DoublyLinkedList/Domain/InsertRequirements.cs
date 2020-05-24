using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Insert
{
    public interface InsertRequirements
    {
        void InsertFirst(Node newNode);
        void InsertLast(Node newNode);
        void InsertAfterFirst(Node newNode); // If the list is empty not do it
        void InsertBeforeLast(Node newNode); // If the list is empty not do it
    }
}
