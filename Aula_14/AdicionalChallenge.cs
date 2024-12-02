using System;
using System.Runtime.CompilerServices;
namespace Aula_14
{
    public class AdicionalChallenge
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

            // Run through the list
            Node? current = begin;
            while (current != null && current.next != null)
            {
                while (current != null)
                {
                    if (current.value == value)
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
                    current = current.next;
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

        static void Main(string[] args)
        {
            Insert(10);
            Insert(20);
            Insert(30);
            Insert(40);
            Insert(20);
            Insert(50);

            Print();

            Delete(20);

            Print();
        }
    }
}
