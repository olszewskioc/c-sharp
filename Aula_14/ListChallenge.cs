using System;
using System.Runtime.CompilerServices;
namespace Aula_14
{
    public class ListChallenge
    {
        class Node
        {
            public int Value;
            public Node? Next;
        }

        private Node? inicio = null;
        private int tam = 0;

        public void Insert(int value, int position)
        {
            // Exercício 1: Inserir em uma posição específica
            // o Escreva uma função para inserir um valor em uma posição específica na
            // lista encadeada. Se a posição for inválida, exiba uma mensagem de erro.
            // o Exemplo de uso:
            // Lista: 10 -> 20 -> 30
            // Inserir(25, 2)
            // Resultado: 10 -> 25 -> 20 -> 30
            Node node = new Node {Value = value, Next = null};

            if (position >= 0 &&position <= tam)
            {
                if (inicio == null)
                {
                    inicio = node;
                    tam++;
                    Console.WriteLine($"{value} Adiconado no início!\n");
                } else
                {
                    Node atual = inicio;
                    int i = 0;
                    while (atual.Next != null && i < position - 1)
                    {
                        atual = atual.Next;
                        i++;
                    }
                    node.Next = atual.Next;
                    atual.Next = node;
                    tam++;
                    Console.WriteLine($"{value} Adiconado na posição {position}!\n");
                }
            }
        }

        public bool Verify(int value)
        {
            // Exercício 2: Verificar se um valor está na lista
            // o Crie uma função que percorra a lista encadeada e verifique se um valor
            // específico existe nela.
            // o Exemplo de uso:
            // Lista: 10 -> 20 -> 30
            // Contem(20) -> true
            // Contem(40) -> false

            Node? node = inicio;
            if (node == null)
            {
                return false;
            }

            if (node.Value == value)
            {
                return true;
            } 
            else 
            {
                while(node.Next != null && node.Value != value)
                {
                    node = node.Next;
                }

                return node.Value == value;
            }
            
        }

        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            Console.Write($"\nlista de tamanho {tam}: ");
            
            Node? atual = inicio;
            while (atual != null)
            {
                Console.Write($"{atual.Value} ");
                atual = atual.Next;
            }
            Console.WriteLine();
        }

        static void Sd(string[] args)
        {
            Console.Clear();
            ListChallenge c = new();
            // // Exercício 1
            c.Insert(10, 0);
            c.Insert(20, 1);
            c.Insert(30, 2);
            c.Insert(40, 1);
            c.Print();

            // // Exercício 2
            // Console.WriteLine($"{c.Verify(30)}");
            // Console.WriteLine($"{c.Verify(50)}");

        }
    }
}
