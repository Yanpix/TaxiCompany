using TaxiCompany.Model.Enum;

namespace TaxiCompany.Model
{
    public class Car
    {
        public int Id { get; set; }
        public CarType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public Driver Owner { get; set; }
    }
}
