using System;
using HWDoublyLinkedList.Node.Domain;

namespace HWDoublyLinkedList.Node.Application.Insert
{
    public interface InsertRequirements
    {
        void InsertFirst(int data);
        void InsertLast(int data);
        void InsertAfterFirst(int data); // If the list is empty not do it
        void InsertBeforeLast(int data); // If the list is empty not do it
    }
}
