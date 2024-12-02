using System;
namespace Aula_14
{
    public class StackChallenge
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
            Console.WriteLine($"Value {value} added in stack!\n");
        }

        public void Top()
        {
            // Exercício 3: Verificar o topo da pilha sem removê-lo
            // o Adicione uma função que permita ver o valor do topo da pilha sem
            // removê-lo.
            // o Exemplo de uso:
            // Pilha: 10 (topo) -> 20 -> 30
            // VerTopo() -> 10
            if (top == null)
                Console.WriteLine($"\nEmpty Stack!\n");
            else
            {
                Console.WriteLine($"\nStack Top: {top.Value}\n");
            }
        }

        public void Reverse()
        {
            // Exercício 4: Reverter uma pilha
            // o Escreva uma função para reverter a ordem dos elementos de uma pilha
            // usando apenas operações de pilha (empilhar e desempilhar).
            // o Exemplo de uso:
            // Pilha original: 10 (topo) -> 20 -> 30
            // Pilha revertida: 30 (topo) -> 20 -> 10

            if (top == null)
                Console.WriteLine($"\nEmpty Stack!\n");
            else if (top.Next == null)
                Console.WriteLine("\nStack with Length 1!\n");
            else
            {
                // Criar uma pilha auxiliar
                Node? previous = null;
                Node? current = top;
                Node? next;

                while (current != null)
                {
                    next = current.Next; // Salva Próximo
                    current.Next = previous; // Altera o próximo do atual para o anterior
                    previous = current; // Atualiza o anterior
                    current = next; // Avança para o próximo
                }
                top = previous;
            }
        }

    

        public void Print()
        {
            if (top == null)
            {
                Console.WriteLine("The stack is empty.");
                return;
            }
            Console.Write($"\nStack Length: {tam}: ");
            
            Node? atual = top;
            while (atual != null)
            {
                Console.Write($"{atual.Value} ");
                atual = atual.Next;
            }
            Console.WriteLine();
        }

        static void SD(string[] args)
        {
            Console.Clear();
            
            StackChallenge c = new();
            
            c.Push(11);
            c.Push(22);
            c.Push(33);
            c.Push(44);
            c.Push(55);

            c.Print();

            c.Top();

            c.Reverse();
            c.Print();
            c.Top();

        }
    }
}