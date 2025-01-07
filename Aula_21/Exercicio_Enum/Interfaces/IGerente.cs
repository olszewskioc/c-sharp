using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21.Exercicio_Enum.Interfaces
{
    public interface IGerente
    {
        void Autorizar();
        bool ConcederAumento(Empregado empregado);
        bool AutorizaLicenca(Empregado empregado);
    }
}