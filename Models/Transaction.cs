namespace BankApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // Ex: "Deposit", "Withdrawal"
                                         // Outros campos conforme necessário
    }
}
