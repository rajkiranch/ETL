using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace SysproIntegration.Library.BusinessLogic.Transformations
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x=>AddAllProfile(Mapper.Configuration));
        }

        private static void AddAllProfile(IConfiguration configuration)
        {
            configuration.AddProfile(new AcumaticaInvoiceMapperProfile());
        }
    }
}
