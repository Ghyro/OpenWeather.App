namespace Core
{
    public interface IStoreServiceBase : IServiceBase
    {
        AppResponse Save(AppRequest request);
    }
}
