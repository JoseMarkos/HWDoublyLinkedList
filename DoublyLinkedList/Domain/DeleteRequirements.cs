using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Delete
{
    public interface DeleteRequirements
    {
        void DeleteFirst();
        void DeleteLast();
        void DeleteAfterFirst();
        void DeleteBiggest();
    }
}
