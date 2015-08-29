using SysproIntegration.Library.BusinessLogic.Transformations;
namespace SysproIntegration.Library
{
    public class StartUp
    {
        public static void Start()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}