using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using Microsoft.VisualStudio.TestPlatform;
using Xunit;

namespace HWDoublyLinkedList.Tests.Insert {
    public class Testing {
        
        [Fact]
        public void CreateNode() 
        {
            Node newNode = new Node(20);

           // Assert.IsAssignableFrom<Node>(newNode.Next);
            Assert.Null(newNode.Next);
            Assert.Null(newNode.Prev);
            Assert.IsType<int>(newNode.Data);
            Assert.Equal(20, newNode.Data);
        }

        [Fact]
        public void InsertFirstCountZero()
        {
            List list = new List();

            Node newNode = new Node(3);

            list.InsertFirst(newNode);

            Assert.Equal(list.Mooc.Next, newNode);
        }

        [Fact]
        public void InsertFirstCountOne()
        {
            List list = GetInsertFirstCountOne();

            Node PreviousHead = list.Head;

            Node newNode2 = new Node(1);
            list.InsertFirst(newNode2);

            Node HeadHappyCase = new Node(1);
            HeadHappyCase.Next = PreviousHead;

            Assert.Equal(HeadHappyCase.Data, list.Head.Data);
            Assert.Equal(HeadHappyCase.Next, list.Head.Next);
            Assert.Equal(HeadHappyCase.Prev, list.Head.Prev);
        }

        [Fact]
        public void InsertFirstCountOneHappyCasePrev()
        {
            List list = new List();

            Node newNode = new Node();
            newNode.Data = 1;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 2;

            list.InsertFirst(newNode2);

            newNode.Prev = list.Mooc.Next;
            Node HeadHappyCase = new Node();
            HeadHappyCase.Data = newNode2.Data;
            HeadHappyCase.Next = newNode;

            Node indirect = list.Mooc;
            
            HeadHappyCase.Prev = indirect;

            Assert.Equal(HeadHappyCase.Prev, indirect.Next.Prev);
        }

        [Fact]
        public void InsertFirstCountOneHappyCaseNextPrev()
        {
            List list = new List();

            Node newNode = new Node();
            newNode.Data = 1;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 2;

            list.InsertFirst(newNode2);
            
            newNode.Prev = list.Mooc.Next;

            Node HeadHappyCase = new Node();
            HeadHappyCase.Data = newNode2.Data;
            HeadHappyCase.Next = newNode;

            Node indirect = list.Mooc;
            
            HeadHappyCase.Prev = indirect;
            System.Console.WriteLine("wow");
            System.Console.WriteLine(HeadHappyCase.Next.Prev.Data);
            System.Console.WriteLine(list.Mooc.Next.Next.Prev.Data);
            Assert.Equal(HeadHappyCase.Next.Prev, list.Mooc.Next.Next.Prev);
        }

        private List GetInsertFirstCountOne() {
            List list = new List();
            Node newNode = new Node(2);
            list.InsertFirst(newNode);

            return list;
        }

        [Fact]
        public void InserAftertFirst()
        {
            List list = new List();
            Node newNode = new Node();
            newNode.Data = 3;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 5;

            list.InserAftertFirst(newNode2);

            newNode.Next = newNode2;
            newNode.Prev = list.Mooc;

            newNode2.Prev = newNode;
            newNode2.Next = null;

            Assert.Equal(newNode, list.Mooc.Next);
            Assert.Equal(newNode2, list.Mooc.Next.Next);
        }

        [Fact]
        public void InserAftertFirstWithThreeItemsHead()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            // move next

            Assert.Equal(10, list.Mooc.Data);
            Assert.Equal(1, list.Mooc.Next.Data);
            Assert.Equal(2, list.Mooc.Next.Next.Data);
            Assert.Equal(3, list.Mooc.Next.Next.Next.Data);
        }


        [Fact]
        public void AddFirstAddAfterFirstAddAfterFirstMooc()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Mooc
            Assert.Equal(10, list.Mooc.Data);
            Assert.Equal(1, list.Mooc.Next.Data);
            Assert.Null(list.Mooc.Prev);
        }

        [Fact]
        public void AddFirstAddAfterFirstAddAfterFirstHead()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Head
            Assert.Equal(1, list.Mooc.Next.Data);
            Assert.Equal(10, list.Mooc.Next.Prev.Data);
            Assert.Equal(2, list.Mooc.Next.Next.Data);
        }

        [Fact]
        public void AddFirstAddAfterFirstAddAfterFirstHeadNext()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Head->Next
            Assert.Equal(2, list.Mooc.Next.Next.Data);
            Assert.Equal(1, list.Mooc.Next.Next.Prev.Data);
            Assert.Equal(3, list.Mooc.Next.Next.Next.Data);
        }

        [Fact]
        public void AddFirstAddAfterFirstAddAfterFirstLastofThree()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Head->Next-Next
            Assert.Equal(3, list.Mooc.Next.Next.Next.Data);
            Assert.Equal(2, list.Mooc.Next.Next.Next.Prev.Data);
            Assert.Null(list.Mooc.Next.Next.Next.Next);
        }

        private List AddFirstAddAfterFirstAddAfterFirst() {
            List list = new List();
            Node newNode = new Node();
            newNode.Data = 1;
            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 3;
            list.InserAftertFirst(newNode2);

            Node newNode3 = new Node();
            newNode3.Data = 2;
            list.InserAftertFirst(newNode3);

            return list;
        }

        [Fact]
        public void InsertLast() {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            Node newNode = new Node();
            newNode.Data = 8;

            list.InsertLast(newNode);

            ListEnumerable enumerable = new ListEnumerable(list);
            IEnumerator<Node> enumerator = enumerable.GetEnumerator();

            Node last = new Node();

            while(enumerator.MoveNext()) 
            {
                last = enumerator.Current;
            }

            Assert.Equal(8, last.Data);
        }
    
        [Fact]
        public void InsertBeforeLast() {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            Node newNode = new Node();
            newNode.Data = 7;

            list.InsertBeforeLast(newNode);

            ListEnumerable enumerable = new ListEnumerable(list);
            IEnumerator<Node> enumerator = enumerable.GetEnumerator();

            Node last = new Node();

            while(enumerator.MoveNext()) 
            {
            }
            
            last = enumerator.Current;  
            
            Assert.Equal(3, last.Data);
            Assert.Equal(7, last.Prev.Data);
            Assert.Equal(2, last.Prev.Prev.Data);
            Assert.Equal(3, last.Prev.Next.Data);
            Assert.Null(last.Next);
        }
    }
}