using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19.Models.Pagamento
{
    public interface IAnuidade
    {
        DateTime CalcularDataVencimento();
        double ValorAnuidade();
    }
}