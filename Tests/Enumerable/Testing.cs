using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.DoublyLinkedNode.Domain;
using HWDoublyLinkedList.DoublyLinkedList.Application;
using Microsoft.VisualStudio.TestPlatform;
using Xunit;

namespace HWDoublyLinkedList.Tests.Enumerable {
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
        public void EnumerableListParamenterEquals() {
            List list = AddFirstAddAfterFirstAddAfterFirst();

            ListEnumerable enumerable = new ListEnumerable(list);

            Assert.Equal(list, enumerable.List);
        }

        [Fact] 
        public void random() {
            List list = AddFirstAddAfterFirstAddAfterFirst();
        }
    }
}