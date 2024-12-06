using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_16_Heranca.Models.Funcionario;
using Aula_16_Heranca.Models.Animal;

namespace Aula_16_Heranca
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Gerente gerente = new("Thiago", 1, "03066987140", 5000, "TI");
            // Secretaria secretaria = new("Ana", 2, "65899865232", 2000, "99");
            // Telefonista telefonista = new("Roberta", 3, "98745612300", 5000, "15");

            // gerente.Print();
            // secretaria.Print();
            // telefonista.Print();
            
            // secretaria.AgendarHorário(DateTime.Now.AddDays(5));
            // telefonista.Atendertelefone();

            Cobra cobra = new(true, true);
            Javali javali = new(true, false);

            Console.WriteLine($"{cobra}    {javali}");

            Console.WriteLine($"Velocidade Max. javali: {javali.GetVelocidadeMaxima()}Km/h");
            cobra.Alimento("Rato");
            javali.SetSelvagem(true);
            cobra.SetVenenosa(false);

            Console.WriteLine($"{cobra}    {javali}");
        }
        
    }
}