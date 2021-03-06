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

            Assert.Equal(newNode, list.Head);
            Assert.Equal(newNode, list.Mooc.Next);
        }

        [Fact]
        public void InsertFirstToListWithOneChild()
        {
            List list = GetInsertFirstToListWithOneChild();

            Node PreviousHead = list.Head;

            Node newNode2 = new Node(1);
            list.InsertFirst(newNode2);

            Node HeadHappyCase = new Node(1);
            PreviousHead.Next = HeadHappyCase;
            HeadHappyCase.Next = PreviousHead;
            
            Assert.Equal(HeadHappyCase.Data, list.Head.Data);
            Assert.Equal(HeadHappyCase.Next, list.Head.Next);
            Assert.Null(list.Head.Prev);
        }

        [Fact]
        public void InsertFirstToListWithOneChildtPrevOfLastChild()
        {
            List list = GetInsertFirstToListWithOneChild();

            Node PreviousHead = list.Head;
            Node newNode2 = new Node(20);

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

            Assert.Equal(HappyCase, list.Head.Next);
            Assert.Equal(HeadHappyCase, list.Head.Next.Prev);
        }

       [Fact]
        public void InsertAfterFirstEmptyListCase()
        {
            List list = new List();
            
            Node newNode = new Node(1);

            Assert.Throws<ArgumentOutOfRangeException>(()=>
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
            List list       = new List();
            Node newNode    = new Node(1);
            list.InsertFirst(newNode);
            Node newNode2   = new Node(3);
            list.InsertAfterFirst(newNode2);
            Node newNode3   = new Node(2);
            list.InsertAfterFirst(newNode3);

            return list;
        }

        /* InsertLast 2 cases:
                - Emptpy list
                - Not Emptpy list
        */

        [Fact]
        public void InsertLastNoChild() 
        {
            List list = new List();
            Node newNode = new Node(8);

            list.InsertLast(newNode);

            Node HappyCase = newNode;

            Assert.Equal<Node>(HappyCase, list.Head);
            Assert.Equal<Node>(HappyCase, list.Tail);
        }

        [Fact]
        public void InsertLastListNotEmpty() 
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            
            Node PreviousTail = list.Tail;

            Node newNode = new Node(8);

            list.InsertLast(newNode);

            Node HappyCase = newNode;
            
            HappyCase.Prev = PreviousTail;
            HappyCase.Prev.Next = HappyCase;
            
            Assert.Equal<Node>(HappyCase, list.Tail);
        }

        [Fact] 
        public void InsertBeforeLastEmptyListCase() 
        {
            List list = new List();

            Assert.Throws<ArgumentOutOfRangeException>(
                ()=> list.InsertBeforeLast(new Node(3))
            );
        } 

        [Fact]
        public void InsertBeforeLastOneChildCase() 
        { 
            List list       = new List();
            Node newNode    = new Node(8);
            list.InsertFirst(newNode);
            Node newNode2   = new Node(9);
            list.InsertBeforeLast(newNode2);

            Assert.Equal(9, list.Head.Data);
            Assert.Equal(8, list.Head.Next.Data);
            Assert.Equal(8, list.Tail.Data);
            Assert.Equal(9, list.Tail.Prev.Data);
        }

        [Fact]
        public void InsertBeforeLastNoEmptyListCase() {
            List list2 = AddFirstAddAfterFirstAddAfterFirst();
            Node newNode = new Node(71);
            list2.InsertBeforeLast(newNode);
            Node HappyCase = new Node(71);
            HappyCase.Next = new Node(3);
            HappyCase.Prev = new Node(2);
            IEnumerator<Node> enumerator = list2.GetEnumerator();

            for (int i = 1; i < list2.Count; i++)
            {
                enumerator.MoveNext();
            }

            Node HappyCaseEnumeable = enumerator.Current;

            Assert.Equal(HappyCase.Data, list2.Tail.Prev.Data);
            Assert.Equal(HappyCase.Next.Data, list2.Tail.Prev.Next.Data);
            Assert.Equal(HappyCase.Prev.Data, list2.Tail.Prev.Prev.Data);
            Assert.Equal(HappyCase.Data, HappyCaseEnumeable.Data);
            Assert.Equal(HappyCase.Next.Data, HappyCaseEnumeable.Next.Data);
            Assert.Equal(HappyCase.Prev.Data, HappyCaseEnumeable.Prev.Data);
        }

        // [Fact]
        // public void Test0()
        // {
        //     Node node1 = new Node(1);
        //     Node node2 = new Node(1);

        //     Assert.Equal(node1, node2);
        // }


        // [Fact]
        // public void Test01()
        // {
        //     Node node1 = new Node(1);
        //     Node node2 = new Node(1);
        //     Node node3 = node1;

        //     node3.Data = 33;

        //     Assert.Equal(node1, node2);
        // }
    }
}