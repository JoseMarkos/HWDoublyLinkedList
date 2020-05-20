using System;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using System.Collections.Generic;
using System.Collections;
using HWDoublyLinkedList.DoublyLinkedList.Application.Insert;
using HWDoublyLinkedList.DoublyLinkedList.Application.Delete;

namespace HWDoublyLinkedList.DoublyLinkedList.Domain
{
    public sealed class List 
    {
        public unsafe Node Mooc;
        public unsafe Node Head;
        public Node Tail;
        public int Count {get; private set;}
        private InsertNode Insert;
        private DeleteNode Delete;

        public List () 
        {
            Count = 0;
            Mooc = new Node();
            Mooc.Data = 10;
            Head = new Node();
            Insert =  new InsertNode();
            Delete =  new DeleteNode();
        }

        public void InsertFirst(Node newNode)
        {
            Insert.InsertFirst(newNode, ref Mooc);
            Count++;
        }

        public void InserAftertFirst(Node newNode)
        {
            Insert.InsertAfterFirst(newNode, ref Mooc);
            Count++;
        }

        public void InsertLast(Node newNode) {
            Insert.InsertLast(newNode, ref Mooc);
            Tail = newNode;
            Count++;
        }

        public void InsertBeforeLast(Node newNode) {
            Insert.InsertBeforeLast(newNode, ref Mooc);
            Count++;
        }

        public void DeleteAfterFirst()
        {
            Delete.DeleteAfterFirst(ref Mooc);
            Count--;
        }

        public void DeleteBiggest()
        {
            Count--;
            throw new NotImplementedException();
        }

        public void DeleteFirst()
        {
            Delete.DeleteFirst(ref Mooc);
            Count--;
        }

        public void DeleteLast()
        {
            Delete.DeleteLast(ref Mooc);
            Count--;
        }
    }
}
