using System;
namespace Aula_13
{
    public class PilhaEncadeada
    {
        class Node
        {
            public int Value;
            public Node? Next;
        }

        private Node? top = null;
        private int tam = 0;

        public void Push(int value)
        {
            Node node = new Node {Value = value, Next = top};
            top = node;
            tam++;
            Console.WriteLine($"Valor {value} adicionado na pilha!\n");
        }

        public void Pop()
        {
            if (top == null)
                Console.WriteLine($"\nPilha vazia!\n");
            else
            {
                Console.WriteLine($"\n{top.Value} removido do topo da pilha!");
                top = top.Next;
                tam--;
            }
        }

        public void Print()
        {
            if (top == null)
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }
            Console.Write($"\nPilha de tamanho {tam}: ");
            
            Node? atual = top;
            while (atual != null)
            {
                Console.Write($"{atual.Value} ");
                atual = atual.Next;
            }
            Console.WriteLine();
        }

        static void Def(string[] args)
        {
            Console.Clear();
            
            PilhaEncadeada lista = new PilhaEncadeada();
            // Criando uma lista
            lista.Push(11);
            lista.Push(22);
            lista.Push(33);

            lista.Print();

            lista.Pop();
            lista.Pop();

            lista.Print();
        }
    }
}