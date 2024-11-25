using System;
namespace Aula_13
{
    public class FilaEncadeada
    {
        class Node
        {
            public int Value;
            public Node? Next;
        }

        private Node? first = null;
        private int tam = 0;

        public void Push(int value)
        {
            Node node= new Node { Value = value, Next = first };
            if (node == null) return;

            if (first == null) first = node;
            else
            {
                Node atual = first;
                while (atual.Next != null)
                {
                    atual = atual.Next;
                }
                atual.Next = node;
            }
            Console.WriteLine($"Valor {value} adicionado na fila!\n");
            tam++;
        }

        public void Pop()
        {
            if (first == null)
            {
                Console.WriteLine($"Fila Vazia!\n");
                return;
            }
            Console.WriteLine($"Valor {first.Value} retirado da fila!\n");
            first = first.Next;
            tam--;
        }

        public void Print()
        {
            if (first == null)
            {
                Console.WriteLine($"Fila Vazia!\n");
                return;
            }
            Console.Write($"\nFila de tamanho {tam}: ");
            Node atual = first;
            while (atual != null)
            {
                Console.WriteLine($"{atual.Value} ");
                atual = atual.Next;
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            
            FilaEncadeada fila = new FilaEncadeada();
            // Criando uma fila
            fila.Push(11);
            fila.Push(22);
            fila.Push(33);

            fila.Print();

            fila.Pop();
            fila.Pop();

            fila.Print();
        }
    }
}