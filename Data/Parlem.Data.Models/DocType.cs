namespace Parlem.Data.Models
{
    using Parlem.Data.Common.Models;

    public class DocType : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
