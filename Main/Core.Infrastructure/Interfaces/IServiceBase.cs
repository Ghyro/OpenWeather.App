namespace Core
{
    public interface IServiceBase
    {
        AppResponse Fetch(AppRequest request);
    }
}
