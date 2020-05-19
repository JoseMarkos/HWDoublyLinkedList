using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedNode.Application.Insert
{
    public interface InsertRequirements
    {
        void InsertFirst(int data);
        void InsertLast(int data);
        void InsertAfterFirst(int data); // If the list is empty not do it
        void InsertBeforeLast(int data); // If the list is empty not do it
    }
}
