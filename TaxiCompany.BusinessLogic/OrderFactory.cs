using System;
using TaxiCompany.Model;

namespace TaxiCompany.BusinessLogic
{
    /// <summary>
    /// creates new order based on input parameters. Defines appropriate tariff and additional fee 
    /// </summary>
    public class OrderFactory
    {
        public Order MakeOrder(string startAddress, string endAddress, DateTime dateTime)
        {
            decimal fee = 0;

            Tariff tariff = new Tariff();

            if (dateTime.TimeOfDay >= new TimeSpan(22, 0, 0))
            {
                fee = 20;
            }

            var km = MapSingleton.GetDistance(startAddress, endAddress);

            if (km >= 10 && km <= 30)
            {
                fee += 10;
                tariff.PricePerKilometer = 10;
            }
            else
            {
                fee += 30;
                tariff.PricePerKilometer = 30;
            }

            var newOrder = new Order();

            newOrder.Tariff = tariff;
            newOrder.Fee = fee;

            return newOrder;
        }
    }
}
