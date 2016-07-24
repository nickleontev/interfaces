using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer_coding_Stack_TutorFromUkraine
{
    class Node
    {
        public int data;
        public Node next;
        public Node()
        {
            this.data = 0;
            this.next = null;

        }
        public Node(int data)
        {
            this.data = data;
            this.next = null;

        }


    }

    class Stack
    {
        private Node begin;
        public Stack()
        {
            this.begin = null;

        }


        private bool IsEmpty()
        {
            return this.begin == null;
        }

        public void Push(int data)
        {
            if (IsEmpty())
            {
                this.begin = new Node(data);
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = this.begin;
                this.begin = newNode;
            }
        }

        public Node Begin
        {
            get
            {
                return this.begin;
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                Node tmp = this.begin;
                this.begin = tmp.next;
                tmp.next = null;
            }

            else
            {
                throw new Exception("Cтэк пуст");
            }
        }


    }
}
