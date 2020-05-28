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
        public void DeleteFirstListNotEmpty() 
        {
            List list = AddFirstAddAfterFirstAddAfterFirst();
            int HappyCase = list.Head.Next.Data;
            list.DeleteFirst();

            Assert.Equal(HappyCase, list.Mooc.Next.Data);
        }

        // [Fact]
        // public void DeleteLast() {
        //     List list = AddFirstAddAfterFirstAddAfterFirst();

        //     Node nodeAfterFirst = list.Mooc.Next.Next;

        //     ListEnumerable enumerable = new ListEnumerable(list);
        //     IEnumerator<Node> enumerator = enumerable.GetEnumerator();


        //     while(enumerator.MoveNext())
        //     {
        //     }

        //     Node last = enumerator.Current.Prev;
            
        //     list.DeleteLast();

        //     enumerator.Dispose();

        //     // ListEnumerable enumerable2 = new ListEnumerable(list);
        //     // IEnumerator<Node> enumerator2 = enumerable2.GetEnumerator();
            
        //     while(enumerator.MoveNext())
        //     {
        //     }

        //     Assert.Equal(last, enumerator.Current);
        // }

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