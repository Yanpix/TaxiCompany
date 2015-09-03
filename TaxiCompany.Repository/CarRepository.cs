using System;
using System.Collections.Generic;
using TaxiCompany.Model;

namespace TaxiCompany.Repository
{
    public class CarRepository:IRepository<Car>
    {
        public IEnumerable<Car> List { get; private set; }
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
