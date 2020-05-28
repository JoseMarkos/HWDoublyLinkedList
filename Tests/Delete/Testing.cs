using System;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using Microsoft.VisualStudio.TestPlatform;
using Xunit;

namespace HWDoublyLinkedList.Tests.Delete {
    public class Testing {
        private List AddFirstAddAfterFirstAddAfterFirst() {
            List list = new List();
            Node newNode = new Node(1);
            list.InsertFirst(newNode);
            Node newNode2 = new Node(3);
            list.InsertAfterFirst(newNode2);
            Node newNode3 = new Node(2);
            list.InsertAfterFirst(newNode3);

            return list;
        }


        [Fact]
        public void DeleteFirstListEmpty()  {
            List list = new List();

            Assert.Throws<IndexOutOfRangeException>(
                () => list.DeleteFirst()
            );
        }

        [Fact]
        public void DeleteFirstOneChild()
        {
            List list = new List();
            Node newNode = new Node(1);
            list.InsertFirst(newNode);
            list.DeleteFirst();

            Assert.Null(list.Mooc.Next);
            Assert.Null(list.Tail);
        }

        [Fact]
        public void DeleteFirstListNotEmpty()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            int HappyCase = list.Head.Next.Data;
            list.DeleteFirst();

            Assert.Equal(HappyCase, list.Mooc.Next.Data);
        }

        [Fact]
        public void DeleteLastEmptyList() 
        {
            List list = new List();
            
            Assert.Throws<IndexOutOfRangeException>(
                () => list.DeleteLast()
            );
        }

        [Fact]
        public void DeleteLastOneChild() 
        {
            List list = new List();
            list.InsertFirst(new Node(1));
            list.DeleteLast();

            Assert.Null(list.Mooc.Next);
            Assert.Null(list.Tail);
        }

        [Fact]
        public void DeleteLastListNotEmpty() 
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            int HappyCase = list.Tail.Prev.Data;
            list.DeleteLast();
            
            Assert.Equal(HappyCase, list.Tail.Data);
            Assert.Null(list.Tail.Next);
        }

        // [Fact]
        // public void DeleteAfterFirst() {
        //     List list = AddFirstAddAfterFirstAddAfterFirst();

        //     Node nodeAfterFirstNext = list.Mooc.Next.Next.Next;
        //     list.DeleteAfterFirst();

        //     Assert.Equal(nodeAfterFirstNext, list.Mooc.Next.Next);
        // }

        // [Fact]
        // public void DeleteAfterFirstCountOne() {
        //     List list = new List();

        //     Node newNode = new Node(1);

        //     list.InsertFirst(newNode);

        //     Assert.Throws<ArgumentOutOfRangeException>(
        //         ()=> list.DeleteAfterFirst()
        //     );
        // }
        
        // [Fact]
        // public void DeleteAfterFirstCountTwo() {
        //     List list = new List();

        //     Node newNode = new Node(1);

        //     list.InsertFirst(newNode);

        //     Node newNode2 = new Node(2);

        //     list.InsertFirst(newNode2);
        //     list.DeleteAfterFirst();

        //     Assert.Null(list.Mooc.Next.Next);
        // }
    }
}