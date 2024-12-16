using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Pagamento
{
    public interface IPagamento
    {
        void Pagar(double valor); // Implicitamente Público
        void Comprovante(); // Implicitamente Público
    }
}