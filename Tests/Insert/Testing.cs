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
            Node newNode = new Node();

            Assert.Null(newNode.Next);
            Assert.Null(newNode.Prev);
            Assert.Equal(0, newNode.Data);
        }

        [Fact]
        public void CreateNodeWithData() 
        {
            Node newNode = new Node();
            newNode.Data = 20;

            Assert.Null(newNode.Next);
            Assert.Null(newNode.Prev);
            Assert.Equal(20, newNode.Data);
            Assert.False(null == newNode);
        }

        [Fact]
        public void AddHeadToList()
        {
            List list = new List();
            Node newNode = new Node();
            newNode.Data = 3;

            list.InsertFirst(newNode);

            Assert.Equal(list.Mooc.Next, newNode);
            Assert.Equal(list.Mooc.Next.Prev, list.Mooc);
        }

        [Fact]
        public void AddFirstToList()
        {
            List list = new List();

            Node newNode = new Node();
            newNode.Data = 1;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 2;

            list.InsertFirst(newNode2);

            // better than a happy node case from scratch, Maybe try Node happy = newNode2
            newNode2.Next = newNode;
            newNode2.Prev = list.Mooc;

            Assert.Equal(newNode2, list.Mooc.Next);
        }

        [Fact]
        public void AddFirstToListIndividual()
        {
            List list = new List();

            Node newNode = new Node();
            newNode.Data = 1;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 2;

            list.InsertFirst(newNode2);

            Node HeadHappyCase = new Node();
            HeadHappyCase.Data = newNode2.Data;
            HeadHappyCase.Next = newNode;
            HeadHappyCase.Prev = list.Mooc;

            Assert.Equal(HeadHappyCase.Data, list.Mooc.Next.Data);
            Assert.Equal(HeadHappyCase.Next, list.Mooc.Next.Next);
            Assert.Equal(HeadHappyCase.Prev, list.Mooc.Next.Prev);
        }


        [Fact]
        public void AddFirstToListHeadNextPrev()
        {
            List list = new List();

            Node newNode = new Node();
            newNode.Data = 1;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 2;

            list.InsertFirst(newNode2);

            Node HeadHappyCase = new Node();
            HeadHappyCase.Data = newNode2.Data;
            HeadHappyCase.Next = newNode;

            Node indirect = list.Mooc;
            
            HeadHappyCase.Prev = indirect;

            Assert.Equal(newNode.Prev, indirect.Next.Next.Prev);
        }

        [Fact]
        public void AddFirstToListHeadPrevNext()
        {
            List list = new List();

            Node newNode = new Node();
            newNode.Data = 1;

            list.InsertFirst(newNode);

            Node newNode2 = new Node();
            newNode2.Data = 2;

            list.InsertFirst(newNode2);

            Node HeadHappyCase = new Node();
            HeadHappyCase.Data = newNode2.Data;
            HeadHappyCase.Next = newNode;

            Node indirect = list.Mooc;
            
            HeadHappyCase.Prev = indirect;

            Assert.Equal(newNode2.Prev.Next, list.Mooc.Next.Prev.Next);
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