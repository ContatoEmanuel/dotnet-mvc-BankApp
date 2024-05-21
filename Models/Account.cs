namespace BankApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Balance { get; set; }
        // Outros campos conforme necessário
    }
}
