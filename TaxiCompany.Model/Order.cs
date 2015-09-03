
using System;
using TaxiCompany.Model.Enum;

namespace TaxiCompany.Model
{
    public class Order
    {
        public long Id { get; set; }
        public string ClientName { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public decimal Kilometers { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }
        /// <summary>
        /// datetime, when car must arrive 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// datetime, when order was registered
        /// </summary>
        public DateTime CreatedDate { get; set; }
        public byte TariffId { get; set; }
        public Tariff Tariff { get; set; }

        public int DispatcherId { get; set; }
        public Dispatcher Dispatcher { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public decimal Price
        {
            get { return Kilometers*Tariff.PricePerKilometer + Fee; }
        }
    }
}
