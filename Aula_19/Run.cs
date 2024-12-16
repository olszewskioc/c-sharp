using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_19.Models.Pagamento;
using Aula_19.Models.Espaco;
using Aula_19.Models.Animal;

namespace Aula_19
{
    public class Run
    {
        static void Main(string[] args)
        {
            // Cartao cartao= new("Thiago", DateTime.Now, 500, "1055 2564 8743 1111");

            // Pix pix= new("67992321168", "Thiago O", "030.669.871-40", 50);

            // cartao.Comprovante();

            // cartao.Pagar(50);

            // pix.Comprovante();
            // pix.Pagar(500);

            // Console.WriteLine($"{cartao.Vencimento}");


            // Circulo circulo= new(10);

            Formiga formiga = new Formiga();
            Cachorro cachorro1 = new Cachorro();
            Cachorro cachorro2 = new Cachorro("Luffy");
            Peixe peixe1 = new Peixe();

            formiga.Come();

            cachorro1.Come();
            cachorro1.Brinca();

            cachorro2.Come();
            cachorro2.Brinca();

            peixe1.Come();
            peixe1.Brinca();

            Console.WriteLine($"{formiga.Pernas} {cachorro1.Pernas} {peixe1.Pernas}");
            
            
            
        }
    }
}