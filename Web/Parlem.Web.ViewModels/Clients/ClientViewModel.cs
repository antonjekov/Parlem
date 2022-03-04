namespace Parlem.Web.ViewModels.Clients
{
    using AutoMapper;
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;
    using Parlem.Web.ViewModels.Documents;

    public class ClientViewModel : IMapFrom<Client>, IHaveCustomMappings
    {
        public int _id { get; set; }

        public string DocType { get; set; }

        public string DocNum { get; set; }

        public string Email { get; set; }

        public int CustomerId { get; set; }

        public string GivenName { get; set; }

        public string FamilyName1 { get; set; }

        public string Phone { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Client, ClientViewModel>()
                .ForMember(dest => dest._id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.DocType, opt => opt.MapFrom(x => x.Document.DocType.Name))
                .ForMember(dest => dest.DocNum, opt => opt.MapFrom(x => x.Document.DocNum));
        }
    }
}
