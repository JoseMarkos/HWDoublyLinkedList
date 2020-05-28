using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application.Delete 
{
    public sealed class DeleteNode : DeleteRequirements
    {
        public void DeleteAfterFirst(ref Node ghost)
        {
            if (ghost.Next.Next is null) {
                throw new ArgumentOutOfRangeException("No existe el indice.");
            }

            if (ghost.Next.Next.Next is null) {
                ghost.Next.Next = null; 
                return;
            }

            Node indirect = ghost.Next.Next.Next;

            indirect.Prev = ghost.Next;

            ghost.Next.Next = indirect; 
        }

        public void DeleteAfterFirst()
        {
            throw new NotImplementedException();
        }

        public void DeleteBiggest(ref Node ghost)
        {
            throw new NotImplementedException();
        }

        public void DeleteBiggest()
        {
            throw new NotImplementedException();
        }

        public void DeleteFirst()
        {
            throw new NotImplementedException();
        }

        public void DeleteLast(ref Node ghost)
        {
            ListEnumerator enumerator = new ListEnumerator(ghost);

            while(enumerator.MoveNext()) 
            {
            }
            
            Node last = enumerator.Current;

            enumerator.Current.Prev.Next = null;
        }

        public void DeleteLast()
        {
            throw new NotImplementedException();
        }
    }
}