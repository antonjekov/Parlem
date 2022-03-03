namespace Parlem.Data.Models
{
    using System.Collections.Generic;

    using Parlem.Data.Common.Models;

    public class Customer : BaseDeletableModel<int>
    {
        public Customer()
            : base()
        {
            this.ProductsSelled = new HashSet<ProductSelled>();
            this.SimpleRoleId = 1;
        }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string Email { get; set; }

        public int SimpleRoleId { get; set; }

        public SimpleRole SimpleRole { get; set; }

        public ICollection<ProductSelled> ProductsSelled { get; set; }
    }
}
