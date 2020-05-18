using System;
using HWDoublyLinkedList.Node.Domain;

namespace HWDoublyLinkedList.Node.Application.Insert
{
    public interface InsertRequirements
    {
        void InsertFirst(LinkedListNode node);
        void InsertLast(LinkedListNode node);
        void InsertAfterFirst(LinkedListNode node); // If the list is empty not do it
        void InsertBeforeLast(LinkedListNode node); // If the list is empty not do it
    }
}
