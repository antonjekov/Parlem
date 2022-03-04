namespace Parlem.Web.ViewModels.ProductSelled
{
    using AutoMapper;
    using Parlem.Data.Models;
    using Parlem.Services.Mapping;
    using System;

    public class ProductSelledViewModel : IMapFrom<ProductSelled>, IHaveCustomMappings
    {
        public int _id { get; set; }

        public string ProductName { get; set; }

        public string ProductTypeName { get; set; }

        public string NumeracioTerminal { get; set; }

        public string SoldAt { get; set; }

        public int CustomerId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ProductSelled, ProductSelledViewModel>()
                .ForMember(dest => dest._id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(x => x.Product.Name))
                .ForMember(dest => dest.ProductTypeName, opt => opt.MapFrom(x => x.Product.TypeName))
                .ForMember(dest => dest.NumeracioTerminal, opt => opt.MapFrom(x => x.TerminalNumber))
                .ForMember(dest => dest.SoldAt, opt => opt.MapFrom(x => x.SoldAt));
        }
    }
}
