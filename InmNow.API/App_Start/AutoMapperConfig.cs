using InmNow.API.ViewModels;
using InmNow.Domain.Models;
using InmNow.Utils.AutoMapper;

namespace InmNow.API
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            ConfigureAutomapperMappings();
        }

        private static void ConfigureAutomapperMappings()
        {
            AutoMapperConfig.CreateMap<InmAbstract, InmAbstractsViewModel>();
            AutoMapperConfig.CreateMap<InmAbstractsViewModel, InmAbstract>();
        }
    }
}