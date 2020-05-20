using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Delete
{
    public interface DeleteRequirements
    {
        void DeleteFirst(Node node);
        void DeleteLast(Node node);
        void DeleteAfterFirst(Node node);
        void DeleteBiggest(Node node);
    }
}
