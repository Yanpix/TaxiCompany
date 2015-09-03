
namespace TaxiCompany.Model
{
    public class Tariff
    {
        public byte Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PricePerKilometer { get; set; }
    }
}
