using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SysproIntegration.Library.Models.Acumatica;
using SysproIntegration.Library.Models.QuickBooks;
using SysproIntegration.Library.Models.CRM;
using SysproIntegration.Library.ViewModels;

namespace SysproIntegration.Library.BusinessLogic.Transformations
{
    public class AcumaticaInvoiceMapperProfile:Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<QbInvoice, AcumaticaInvoice>()
                .ForMember(src => src.Column4, dest => dest.MapFrom(d => d.Column1))
                .ForMember(src => src.Column5, dest => dest.MapFrom(d => d.Column2));
        }
    }

   
}
