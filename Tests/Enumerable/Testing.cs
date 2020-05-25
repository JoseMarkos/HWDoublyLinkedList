using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using Microsoft.VisualStudio.TestPlatform;
using Xunit;
using System.Collections.Generic;

namespace HWDoublyLinkedList.Tests.Enumerable {
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
        public void EnumerableListParamenterEquals() {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            ListEnumerable enumerable = new ListEnumerable(list);

            Assert.Equal(list, enumerable.List);
        }

        [Fact]
        public void EnumeratorMoveNext() {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            ListEnumerable enumerable = new ListEnumerable(list);
            IEnumerator<Node> enumerator = enumerable.GetEnumerator();

            while(enumerator.MoveNext())
            {
                
            }
            
            Assert.Equal(3, enumerator.Current.Data);
        }

        // Dispose
    }
}