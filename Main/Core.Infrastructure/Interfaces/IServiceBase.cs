namespace Core
{
    public interface IServiceBase
    {
        FetchDataResponse Fetch(FetchDataRequest request);
    }
}
