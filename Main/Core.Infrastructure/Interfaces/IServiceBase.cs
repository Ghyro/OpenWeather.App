namespace Core
{
    public interface IServiceBase
    {
        void Handle(AppRequest request, AppResponse response);

        AppResponse Fetch(AppRequest request);
    }
}
