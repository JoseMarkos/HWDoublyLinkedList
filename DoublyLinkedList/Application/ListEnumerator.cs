using System;
using System.Collections;
using System.Collections.Generic;
using HWDoublyLinkedList.DoublyLinkedList.Domain;
using HWDoublyLinkedList.Node.Domain;

namespace HWDoublyLinkedList.DoublyLinkedList.Application
{
    public sealed class ListEnumerator : IEnumerator<int>
    {
        private List DoublyList;
        private LinkedListNode Indirect;
        private LinkedListNode _indirect;
        private static int _current;

        public static int Count {get; private set;}

        public ListEnumerator(List injectList) {
            DoublyList = injectList;

            LinkedListNode HeadNode = (LinkedListNode)DoublyList.Head;

            System.Console.WriteLine(HeadNode.Data);
            unsafe {
                Indirect = new LinkedListNode()
                {
                    Next = &HeadNode,
                    Prev = null
                };

                _indirect= Indirect;
            }
            
            System.Console.WriteLine(_indirect.Data + " from construct");
        }

        public int Current {
            get
            {
                unsafe {
                    if (Indirect.Equals(null))
                    {
                        throw new InvalidOperationException();
                    }

                    return _current;
                }
            }
        }

        object IEnumerator.Current {
            get { return Current; }
        } 

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            unsafe 
            {
                if (!(*Indirect.Next).Equals(null)) 
                {
                    LinkedListNode _ = (*Indirect.Next);

                    _current = _.Data;
                    
                    Indirect = (*Indirect.Next); 

                    System.Console.WriteLine("wth current " + _current);

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
