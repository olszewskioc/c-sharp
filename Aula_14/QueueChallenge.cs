using System;
namespace Aula_14
{
    public class QueueChallenge
    {
        class Node
        {
            public int Value;
            public Node? Next;
        }

        private Node? first = null;
        private Node? first2 = null;
        private int tam = 0;
        private int tam2 = 0;

        public void Push1(int value)
        {
            Node node = new Node { Value = value };
            if (first == null)
                first = node;
            else
            {
                Node atual = first;
                while (atual.Next != null)
                {
                    atual = atual.Next;
                }
                atual.Next = node;
            }
            Console.WriteLine($"Valor {value} adicionado na Fila 1!\n");
            tam++;
        }

        public void Push2(int value)
        {
            Node node = new Node { Value = value };
            if (first2 == null)
                first2 = node;
            else
            {
                Node atual = first2;
                while (atual.Next != null)
                {
                    atual = atual.Next;
                }
                atual.Next = node;
            }
            Console.WriteLine($"Valor {value} adicionado na Fila 2!\n");
            tam2++;
        }

        public void ConcatQueues()
        {
            // Exercício 5: Inserir elementos de outra fila
            // o Crie uma função que insira os elementos de uma segunda fila no final da
            // fila atual.
            // o Exemplo de uso:
            // Fila 1: 10 -> 20
            // Fila 2: 30 -> 40
            // Resultado: 10 -> 20 -> 30 -> 40
            if (first == null) // Se a primeira fila está vazia, a segunda fila se torna a primeira.
            {
                first = first2;
            }
            else
            {
                Node atual = first;
                while (atual.Next != null) // Percorre até o final da primeira fila.
                {
                    atual = atual.Next;
                }
                atual.Next = first2; // Conecta o final da primeira fila ao início da segunda.
            }
            tam += tam2; // Atualiza o tamanho total.
            first2 = null; // Limpa a segunda fila após a concatenação.
            tam2 = 0;
            Console.WriteLine("Filas concatenadas com sucesso!");
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
                Console.Write($"{atual.Value} ");
                atual = atual.Next;
            }
            Console.WriteLine($"");
        }
        public void Print2()
        {
            if (first2 == null)
            {
                Console.WriteLine($"Fila Vazia!\n");
                return;
            }
            Console.Write($"\nFila de tamanho {tam2}: ");
            Node atual = first2;
            while (atual != null)
            {
                Console.Write($"{atual.Value} ");
                atual = atual.Next;
            }
            Console.WriteLine($"");
        }

        public int Size()
        {
            // Exercício 6: Verificar o tamanho da fila
            // o Implemente uma função que calcule o número de elementos na fila.
            // o Exemplo de uso:
            // Fila: 10 -> 20 -> 30
            // Tamanho() -> 3
            return tam;
        }

        static void Faa(string[] args)
        {
            QueueChallenge q = new QueueChallenge();
            q.Push1(10);
            q.Push1(20);

            q.Push2(40);
            q.Push2(50);

            q.Print();
            q.Print2();

            q.ConcatQueues();
            q.Print();
            Console.WriteLine($"{q.Size()}");
            

        }
    }
}