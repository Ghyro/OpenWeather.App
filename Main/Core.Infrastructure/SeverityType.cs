using System.Runtime.Serialization;


namespace Core
{
    [DataContract]
    public enum SeverityType
    {
        [EnumMember]
        Information,
        [EnumMember]
        Success,
        [EnumMember]
        Warning,
        [EnumMember]
        Error,
        [EnumMember]
        Critical
    }
}
