using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        //public static void RegisterMappings()
        //{
        //    Mapper.Initialize(x =>
        //    {
        //        x.AddProfile<DomainToViewModelMappingProfile>();
        //        x.AddProfile<ViewModelToDomainMappingProfile>();
        //    });
        //} //Obsoleto

        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            }
           );

            return config;
        }
    }
}