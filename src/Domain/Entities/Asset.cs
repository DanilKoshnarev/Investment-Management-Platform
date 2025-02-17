namespace InvestmentManagement.Domain.Entities
{
    public class Asset
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }

        public Asset(string id, string name, string type, decimal value)
        {
            Id = id;
            Name = name;
            Type = type;
            Value = value;
        }
    }
}
