using System;
using HWDoublyLinkedList.Node.Domain;

namespace HWDoublyLinkedList.Node.Application.Delete
{
    public interface DeleteRequirements
    {
        void DeleteFirst(LinkedListNode node);
        void DeleteLast(LinkedListNode node);
        void DeleteAfterFirst(LinkedListNode node);
        void DeleteBiggest(LinkedListNode node);
    }
}
