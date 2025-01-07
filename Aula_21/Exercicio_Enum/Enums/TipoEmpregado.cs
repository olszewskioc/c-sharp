using System.Reflection.Metadata.Ecma335;

namespace Aula_21.Exercicio_Enum.Enums
{
    public enum TipoEmpregado
    {
        Vendedor, GerenteVendas, GerenteProducao
    }

    public class EmpregadoHelper
    {
        public static string GetTipo(TipoEmpregado tipo) => tipo switch 
        {
            TipoEmpregado.Vendedor => "Vendedor",
            TipoEmpregado.GerenteVendas => "Gerente de Vendas",
            TipoEmpregado.GerenteProducao => "Gerente de Produção",
            _ => "Tipo inexistente para o empregado.",
        };
    }
}