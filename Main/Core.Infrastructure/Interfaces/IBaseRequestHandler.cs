namespace Core
{
    public interface IBaseRequestHandler
    {
        AppResponse DoHandle(AppRequest request);
    }
}
