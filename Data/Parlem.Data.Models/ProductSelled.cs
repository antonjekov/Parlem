namespace Parlem.Data.Models
{
    using System;

    using Parlem.Data.Common.Models;

    public class ProductSelled : BaseDeletableModel<int>
    {
        public DateTime SoldAt { get; set; }

        public int TerminalNumber { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
