namespace Parlem.Web.ViewModels.Clients
{
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;
    using Parlem.Web.ViewModels.Documents;

    public class ClientViewModel : IMapFrom<Client>
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }

        public DocumentViewModel Document { get; set; }

        public string DocNum => this.Document.DocNum;

        public string GivenName { get; set; }

        public string FamilyName1 { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
