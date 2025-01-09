namespace Desafio_Bancario.Models.Enums
{
    public enum TransactionType
    {
        DEPOSIT, WITHDRAW, TED, DOC, PIX
    }

    public class TransactionHelper
    {
        public static string GetType(TransactionType transaction)
        {
            return transaction switch
            {
                TransactionType.DEPOSIT => "Deposit",
                TransactionType.WITHDRAW => "Withdraw",
                TransactionType.TED => "TED",
                TransactionType.DOC => "DOC",
                TransactionType.PIX => "PIX",
                _ => $"Transaction type {transaction} doesn't exist!",
            };
        }
    }
}