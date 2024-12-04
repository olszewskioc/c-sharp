using System;
namespace Aula_15
{
    public class Cachorro
    {
        public string ?nome;
        public string ?raca;
        public int idade;

        public void Escreve()
        {
            Console.WriteLine($"Nome: {nome}\nRaça: {raca}\nIdade: {idade}\nIdade Humana: {GetIdadeHumana()}");
        }

        public int GetIdadeHumana()
        {
            if (idade <= 2)
                return idade * 11;
            else
                return 22 + ((idade - 2) * 5);
        }

    }
}