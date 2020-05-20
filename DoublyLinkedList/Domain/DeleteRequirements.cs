using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Delete
{
    public interface DeleteRequirements
    {
        void DeleteFirst(ref Node ghost);
        void DeleteLast(Node node, ref Node ghost);
        void DeleteAfterFirst(Node node, ref Node ghost);
        void DeleteBiggest(Node node, ref Node ghost);
    }
}
