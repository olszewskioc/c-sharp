namespace Desafio_Bancario.Models.Enums
{
    public enum State
    {
        AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI,
        RJ, RN, RS, RO, RR, SC, SP, SE, TO
    }
    public class EstadoHelper
    {
        // Método para obter a região com base no estado
        public static string GetRegion(State state)
        {
            return state switch
            {
                // Norte
                State.AC or State.AP or State.AM or State.PA or State.RO or State.RR or State.TO => "Norte",
                // Nordeste
                State.AL or State.BA or State.CE or State.MA or State.PB or State.PE or State.PI or State.RN or State.SE => "Nordeste",
                // Centro-Oeste
                State.DF or State.GO or State.MT or State.MS => "Centro-Oeste",
                // Sudeste
                State.ES or State.MG or State.RJ or State.SP => "Sudeste",
                // Sul
                State.PR or State.RS or State.SC => "Sul",
                _ => "Região não identificada"
            };
        }

        public static string GetState(State state)
        {
            return state switch
            {
                State.AC => "Acre",
                State.AL => "Alagoas",
                State.AP => "Amapá",
                State.AM => "Amazonas",
                State.BA => "Bahia",
                State.CE => "Ceará",
                State.DF => "Distrito Federal",
                State.ES => "Espírito Santo",
                State.GO => "Goiás",
                State.MA => "Maranhão",
                State.MT => "Mato Grosso",
                State.MS => "Mato Grosso do Sul",
                State.MG => "Minas Gerais",
                State.PA => "Pará",
                State.PB => "Paraíba",
                State.PE => "Pernambuco",
                State.PI => "Piauí",
                State.RJ => "Rio de Janeiro",
                State.RN => "Rio Grande do Norte",
                State.RS => "Rio Grande do Sul",
                State.RR => "Rondônia",
                State.RO => "Roraima",
                State.SC => "Santa Catarina",
                State.SP => "São Paulo",
                State.SE => "Sergipe",
                State.TO => "Tocantins",
                _ => "Estado não encontrado",
            };
        }
    }
}