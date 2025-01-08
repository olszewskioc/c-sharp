using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23.Models
{
    public class DomainException(string message) : ApplicationException(message)
    {
        
    }
}