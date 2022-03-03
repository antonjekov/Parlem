namespace Parlem.Web.ViewModels.Documents
{
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;

    public class DocumentViewModel : IMapFrom<Document>
    {
        public int DocTypeId { get; set; }

        public DocType DocType { get; set; }

        public string DocNum { get; set; }
    }
}
