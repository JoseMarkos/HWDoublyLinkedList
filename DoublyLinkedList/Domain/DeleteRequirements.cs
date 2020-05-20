using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Delete
{
    public interface DeleteRequirements
    {
        void DeleteFirst(ref Node ghost);
        void DeleteLast(ref Node ghost);
        void DeleteAfterFirst(ref Node ghost);
        void DeleteBiggest(ref Node ghost);
    }
}
