using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Bancario.Models.Interfaces
{
    public interface IAccountActions
    {
        bool Deposit(double value);
        bool Withdraw(double value);
        bool CreateTransaction();
    }
}