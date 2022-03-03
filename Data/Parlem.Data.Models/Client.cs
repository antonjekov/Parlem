namespace Parlem.Data.Models
{
    using System.Collections.Generic;

    using Parlem.Data.Common.Models;

    public class Client : BaseDeletableModel<int>
    {
        public Client()
            : base()
        {
            this.ProductsSelled = new HashSet<ProductSelled>();
            this.SimpleRoleId = 2;
        }

        public string GivenName { get; set; }

        public string FamilyName1 { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int DocumentId { get; set; }

        public Document Document { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int SimpleRoleId { get; set; }

        public SimpleRole SimpleRole { get; set; }

        public ICollection<ProductSelled> ProductsSelled { get; set; }
    }
}
