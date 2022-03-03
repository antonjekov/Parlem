namespace Parlem.Data.Models
{
    using Parlem.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string TypeName { get; set; }
    }
}
