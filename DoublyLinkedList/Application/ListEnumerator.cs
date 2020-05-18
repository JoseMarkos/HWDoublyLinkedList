using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.Node.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerator : IEnumerator<LinkedListNode>
    {
        private List DoublyList;
        private LinkedListNode Indirect;
        private LinkedListNode _indirect;
        private LinkedListNode _current;

        public static int Count {get; private set;}

        public ListEnumerator(List injectList) {
            DoublyList = injectList;

            unsafe {
                fixed (LinkedListNode* HeadNode = &DoublyList.Head)

                Indirect = new LinkedListNode()
                {
                    Data = 0,
                    Next = HeadNode,
                    Prev = null
                };
            }

            _current = new LinkedListNode();
        }

        public LinkedListNode Current {
            get
            {
                unsafe {
                    LinkedListNode hola = new LinkedListNode();

                    if ((*Indirect.Next).Equals(hola))
                    {
                        return _current;
                    }

                    return _current;
                }
            }
        }

        object IEnumerator.Current {
            get { return 5; }
        } 

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            unsafe 
            {
                LinkedListNode hola = new LinkedListNode();

                System.Console.WriteLine("indirect next data " + (*Indirect.Next).Data);
                System.Console.WriteLine("Indirect data " + Indirect.Data);
                
                if (!(*Indirect.Next).Equals(hola)) 
                {
                    _current = (*Indirect.Next);

                    System.Console.WriteLine("wth current " + _current.Data);

                    return true;
                }
            }
                
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
