using System;
namespace Aula_13
{
    public class ListaEncadeada
    {
        // private delegate void FuncDelegate(int valor);
        // static FuncDelegate? inicio = null;
        // static FuncDelegate CriarNo(int valor, FuncDelegate? proximo = null)
        // {
        //     return v =>
        //     {
        //         Console.WriteLine($"{valor}");
        //         proximo?.Invoke(v);
        //     };
        // }

        class Node
        {
            public int Value;
            public Node? Next;
        }

        private Node? inicio = null;
        private int tam = 0;

        public void Insert(int value)
        {
            Node node = new Node {Value = value, Next = null};

            if (inicio == null)
            {
                inicio = node;
                tam++;
                Console.WriteLine($"{value} Adiconado no início!\n");
            } else
            {
                Node atual = inicio;
                while (atual.Next != null)
                {
                    atual = atual.Next;
                }
                atual.Next = node;
                tam++;
                Console.WriteLine($"{value} Adiconado!\n");
            }
        }

        public void Remove(int value)
        {
            if (inicio == null) return;
            
            if (inicio.Value == value)
            {
                inicio = inicio.Next;
                tam--;
                Console.WriteLine($"\n{value} removido no início!\n");
                return;
            } else 
            {
                Node atual = inicio;
                while (atual.Next != null && atual.Next.Value != value)
                {
                    atual = atual.Next;
                }

                if (atual.Next != null)
                {
                    Console.WriteLine($"\n{value} removido!\n");
                    atual.Next = atual.Next.Next;
                    tam--;

                } else Console.WriteLine($"\n{value} não encontrado para remoção!\n");
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

        static void Se(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();
            // Criando uma lista
            lista.Insert(11);
            lista.Insert(22);
            lista.Insert(33);

            lista.Print();

            lista.Remove(33);
            lista.Remove(12);

            lista.Print();
        }
    }
}