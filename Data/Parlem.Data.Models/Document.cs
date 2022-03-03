namespace Parlem.Data.Models
{
    using Parlem.Data.Common.Models;

    public class Document : BaseDeletableModel<int>
    {
        public int DocTypeId { get; set; }

        public DocType DocType { get; set; }

        public string DocNum { get; set; }
    }
}
