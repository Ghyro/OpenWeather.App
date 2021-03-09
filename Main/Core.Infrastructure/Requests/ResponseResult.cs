using System.Runtime.Serialization;


namespace Core
{
    [DataContract]
    public enum ResponseResult
    {
        [EnumMember]
        Success = 0,
        [EnumMember]
        Failure
    }
}
