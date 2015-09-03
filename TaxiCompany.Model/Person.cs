using System;

namespace TaxiCompany.Model
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
