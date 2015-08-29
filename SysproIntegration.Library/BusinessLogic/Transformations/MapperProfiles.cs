using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SysproIntegration.Library.Models.Acumatica;
using SysproIntegration.Library.Models.QuickBooks;

namespace SysproIntegration.Library.BusinessLogic.Transformations
{
    public class AcumaticaInvoiceMapperProfile:Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<QbInvoice, Invoice>()
                .ForMember(src => src.Column4, dest => dest.MapFrom(d => d.Column1))
                .ForMember(src => src.Column5, dest => dest.MapFrom(d => d.Column2));
        }
    }
}
