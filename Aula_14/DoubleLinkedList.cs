using System;
using System.Runtime.CompilerServices;
namespace Aula_14
{
    public class DoubleLinkedList
    {
        class Node
        {
            public int value;
            public Node? next;
            public Node? previous;
        }

        static Node? begin = null;

        static void Insert(int value)
        {
            Node? newNode = new Node {value = value, next = null, previous = null};
            if (begin == null)
                begin = newNode;
            else
            {
                Node current = begin;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
                newNode.previous = current;
            }
        }

        static void Delete(int value)
        {
            // Empty list?
            if (begin == null)
            {
                Console.WriteLine($"\nEmpty List!\n");
                return;
            }
            
            // Value in begin?
            if (begin.value == value)
            {
                if (begin.next != null)
                {
                    begin.next.previous = null;
                }
                begin = begin.next;
                return;
            }

            // Run through the list
            Node? current = begin;
            while (current != null && current.value != value)
            {
                current = current.next;
            }

            if (current != null)
            {
                if (current.previous != null)
                {
                    current.previous.next = current.next;
                }
                if (current.next != null)
                {
                    current.next.previous = current.previous;
                }
            }
        }

        static void Print()
        {
            Node? current = begin;
            while (current != null)
            {
                Console.Write($"{current.value} ");
                current = current.next;
            }
            Console.WriteLine($"");
        }

        static void FDAF(string[] args)
        {
            Insert(10);
            Insert(20);
            Insert(30);

            Print();

            Delete(20);
            Insert(40);
            Print();
        }
    }
}
