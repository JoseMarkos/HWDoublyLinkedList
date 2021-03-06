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

            Assert.Throws<ArgumentOutOfRangeException>(
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

            Assert.Throws<ArgumentOutOfRangeException>(
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

        [Fact]
        public void DeleteAfterFirstListEmpty()
        {
            List list = new List();

            Assert.Throws<ArgumentOutOfRangeException>(
                () => list.DeleteAfterFirst()
            );
        }

        [Fact]
        public void DeleteAfterFirstOneChild()
        {
            List list = new List();
            list.InsertFirst(new Node(1));

            Assert.Throws<ArgumentOutOfRangeException>(
                () => list.DeleteAfterFirst()
            );
        }

        [Fact]
        public void DeleteAfterFirstTwoChilds()
        {
            List list = new List();
            list.InsertFirst(new Node(2));
            list.InsertFirst(new Node(1));
            list.DeleteAfterFirst();

            Assert.Null(list.Mooc.Next.Next);
            Assert.Equal(list.Mooc.Next, list.Tail);
        }

        [Fact]
        public void DeleteAfterFirstListNotEmpty()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            int HappyCase = list.Head.Next.Next.Data;
            list.DeleteAfterFirst();

            Assert.Equal(HappyCase, list.Mooc.Next.Next.Data);
        }

        [Fact]
        public void DeleteBiggestListEmpty()
        {
            List list = new List();

            Assert.Throws<ArgumentOutOfRangeException>(
                () => list.DeleteBiggest()
            );
        }

        [Fact]
        public void DeleteBiggestOneChild()
        {
            List list = new List();
            list.InsertFirst(new Node(1));
            list.DeleteBiggest();
            Assert.Null(list.Head);
        }

        [Fact]
        public void DeleteBiggestListNotEmpty()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            list.DeleteBiggest();
            var enumerator = list.GetEnumerator();

            while(enumerator.MoveNext())
            {
            }
            Assert.Equal(2, enumerator.Current.Data);
        }
    }
}