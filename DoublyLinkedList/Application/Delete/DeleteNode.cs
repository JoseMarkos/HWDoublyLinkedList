using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Delete 
{
    public sealed class DeleteNode : DeleteRequirements
    {
        public void DeleteAfterFirst(Node node, ref Node ghost)
        {
            throw new NotImplementedException();
        }

        public void DeleteBiggest(Node node, ref Node ghost)
        {
            throw new NotImplementedException();
        }

        public void DeleteFirst(ref Node ghost)
        {
            ghost.Next.Next.Prev = ghost;
            ghost.Next = ghost.Next.Next;
        }

        public void DeleteLast(Node node, ref Node ghost)
        {
            throw new NotImplementedException();
        }
    }
}