namespace InvestmentManagement.Domain.Entities
{
    public class Transaction
    {
        public string Id { get; set; }
        public string AssetId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(string id, string assetId, decimal amount, DateTime date)
        {
            Id = id;
            AssetId = assetId;
            Amount = amount;
            Date = date;
        }
    }
}
