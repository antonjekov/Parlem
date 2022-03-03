namespace Parlem.Data.Models
{
    using System.Collections.Generic;

    using Parlem.Data.Common.Models;

    public class SimpleRole : BaseDeletableModel<int>
    {
        public SimpleRole()
        {
            this.Clients = new HashSet<Client>();
            this.Customers = new HashSet<Customer>();
        }

        public string Name { get; set; }

        public ICollection<Client> Clients { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
