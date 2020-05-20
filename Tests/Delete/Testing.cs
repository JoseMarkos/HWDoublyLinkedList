using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using Microsoft.VisualStudio.TestPlatform;
using Xunit;

namespace HWDoublyLinkedList.Tests.Delete {
    public class Testing {
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
        public void DeleteFirst() {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            Node nodeAfterFirst = list.Mooc.Next.Next;
            list.DeleteFirst();

            Assert.Equal(nodeAfterFirst, list.Mooc.Next);
        }

        [Fact]
        public void DeleteLast() {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            Node nodeAfterFirst = list.Mooc.Next.Next;

            ListEnumerable enumerable = new ListEnumerable(list);
            IEnumerator<Node> enumerator = enumerable.GetEnumerator();

            Node last = new Node();

            while(enumerator.MoveNext())
            {
            }

            last = enumerator.Current.Prev;
            
            list.DeleteLast();

            enumerator.Dispose();

            // ListEnumerable enumerable2 = new ListEnumerable(list);
            // IEnumerator<Node> enumerator2 = enumerable2.GetEnumerator();
            
            while(enumerator.MoveNext())
            {
            }

            Assert.Equal(last, enumerator.Current);
        }
    }
}