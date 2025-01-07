namespace Aula_21.Exercicio_Enum.Enums
{
    public enum Estado
    {
        AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI,
        RJ, RN, RS, RO, RR, SC, SP, SE, TO
    }

    public class EstadoHelper
    {
        // Método para obter a região com base no estado
        public static string GetRegiao(Estado estado)
        {
            return estado switch
            {
                // Norte
                Estado.AC or Estado.AP or Estado.AM or Estado.PA or Estado.RO or Estado.RR or Estado.TO => "Norte",
                // Nordeste
                Estado.AL or Estado.BA or Estado.CE or Estado.MA or Estado.PB or Estado.PE or Estado.PI or Estado.RN or Estado.SE => "Nordeste",
                // Centro-Oeste
                Estado.DF or Estado.GO or Estado.MT or Estado.MS => "Centro-Oeste",
                // Sudeste
                Estado.ES or Estado.MG or Estado.RJ or Estado.SP => "Sudeste",
                // Sul
                Estado.PR or Estado.RS or Estado.SC => "Sul",
                _ => "Região não identificada"
            };
        }
    }
}