using System.Collections.Generic;
using TaxiCompany.Model;

namespace TaxiCompany.Repository
{
    public class OrderRepository:IRepository<Order>
    {
        public IEnumerable<Order> List { get; private set; }
        public void Add(Order entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new System.NotImplementedException();
        }

        public Order FindById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
