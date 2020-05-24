using System;
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
        public void InsertFirstToListWithNoChild()
        {
            List list = new List();

            Node newNode = new Node(3);

            list.InsertFirst(newNode);

            Assert.Equal(list.Head, newNode);
            Assert.Equal(list.Mooc.Next, newNode);
        }

        [Fact]
        public void InsertFirstToListWithOneChild()
        {
            List list = GetInsertFirstToListWithOneChild();

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
        public void InsertFirstToListWithOneChildtPrevOfLastChild()
        {
            List list = GetInsertFirstToListWithOneChild();

            Node PreviousHead = list.Head;
            Node newNode2 = new Node(2);

            Node HeadHappyCase = newNode2;
            HeadHappyCase.Next = PreviousHead;

            list.InsertFirst(newNode2);
            
            Node TailHappyCase = new Node(newNode2.Data);
            TailHappyCase.Prev = HeadHappyCase;

            Assert.Equal(TailHappyCase.Prev, list.Tail.Prev);
        }

        private List GetInsertFirstToListWithOneChild() {
            List list = new List();
            Node newNode = new Node(2);
            list.InsertFirst(newNode);

            return list;
        }

        [Fact]
        public void InsertAfterFirst()
        {
            List list = GetInsertFirstToListWithOneChild();
            Node HeadHappyCase = list.Head;

            Node newNode2 = new Node(3);

            list.InsertAfterFirst(newNode2);

            Node HappyCase = newNode2;
            HappyCase.Prev = HeadHappyCase;

            HeadHappyCase.Next = HappyCase;

            System.Console.WriteLine(HappyCase.Prev.Next);
            Assert.Equal(HappyCase, list.Head.Next);
            Assert.Equal(HappyCase.Prev.Next, list.Head.Next.Prev.Next);
            Assert.Equal(HeadHappyCase, list.Head.Next.Prev);
        }

       [Fact]
        public void InsertAfterFirstEmptyListCase()
        {
            List list = new List();
            
            Node newNode = new Node(1);

            Assert.Throws<IndexOutOfRangeException>(()=>
                list.InsertAfterFirst(newNode)
                );
        }
        

        [Fact]
        public void InsertAfterFirstWithThreeItems()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            // move next

            Assert.Equal(0, list.Mooc.Data);
            Assert.Equal(1, list.Mooc.Next.Data);
            Assert.Equal(2, list.Mooc.Next.Next.Data);
            Assert.Equal(3, list.Mooc.Next.Next.Next.Data);
        }


        [Fact]
        public void InsertAfterFirstWithThreeItemsMooc()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Mooc
            Assert.Equal(0, list.Mooc.Data);
            Assert.Equal(1, list.Mooc.Next.Data);
            Assert.Null(list.Mooc.Prev);
        }

        [Fact]
        public void InsertAfterFirstWithThreeItemsHead()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Head
            Assert.Equal(1, list.Mooc.Next.Data);
            Assert.Null(list.Mooc.Next.Prev);
            Assert.Equal(2, list.Mooc.Next.Next.Data);
        }

        [Fact]
        public void InsertAfterFirstWithThreeItemsHeadNext()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Head->Next
            Assert.Equal(2, list.Mooc.Next.Next.Data);
            Assert.Equal(1, list.Mooc.Next.Next.Prev.Data);
            Assert.Equal(3, list.Mooc.Next.Next.Next.Data);
        }

        [Fact]
        public void InsertAfterFirstWithThreeItemsLast()
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            // Head->Next-Next
            Assert.Equal(3, list.Mooc.Next.Next.Next.Data);
            Assert.Equal(2, list.Mooc.Next.Next.Next.Prev.Data);
            Assert.Null(list.Mooc.Next.Next.Next.Next);
        }

        private List AddFirstAddAfterFirstAddAfterFirst() {
            List list = new List();
            Node newNode = new Node(1);
            newNode.Data = 1;
            list.InsertFirst(newNode);

            Node newNode2 = new Node(3);
            newNode2.Data = 3;
            list.InsertAfterFirst(newNode2);

            Node newNode3 = new Node(2);
            newNode3.Data = 2;
            list.InsertAfterFirst(newNode3);

            return list;
        }

        // [Fact]
        // public void InsertLast() {
        //     List list = AddFirstAddAfterFirstAddAfterFirst();
        //     Node newNode = new Node(8);
        //     newNode.Data = 8;

        //     list.InsertLast(newNode);

        //     ListEnumerable enumerable = new ListEnumerable(list);
        //     IEnumerator<Node> enumerator = enumerable.GetEnumerator();


        //     while(enumerator.MoveNext()) 
        //     {
        //     }

        //     Node last = enumerator.Current;
            
        //     Assert.Equal(8, last.Data);
        // }
    
        // [Fact]
        // public void InsertBeforeLast() {
        //     List list = AddFirstAddAfterFirstAddAfterFirst();
        //     Node newNode = new Node(7);
        //     newNode.Data = 7;

        //     list.InsertBeforeLast(newNode);

        //     ListEnumerable enumerable = new ListEnumerable(list);
        //     IEnumerator<Node> enumerator = enumerable.GetEnumerator();


        //     while(enumerator.MoveNext()) 
        //     {
        //     }
            
        //     Node last = enumerator.Current;  
            
        //     Assert.Equal(3, last.Data);
        //     Assert.Equal(7, last.Prev.Data);
        //     Assert.Equal(2, last.Prev.Prev.Data);
        //     Assert.Equal(3, last.Prev.Next.Data);
        //     Assert.Null(last.Next);
        // }
    }
}