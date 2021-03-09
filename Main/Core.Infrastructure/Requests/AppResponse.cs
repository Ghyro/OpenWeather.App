using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Core
{
    [DataContract(Name="AppResp")]
    public abstract class AppResponse : IHasId, IAlertContainer
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "RequestId")]
        public string RequestId { get; set; }

        [DataMember(Name = "Alerts")]
        public List<Alert> Alerts { get; set; }

        [DataMember(Name = "Requests")]
        public List<AppRequest> Requests { get; set; }

        [DataMember(Name = "Id")]
        public ResponseResult ResponseResult { get; set; }

        public void AddAlerts(IEnumerable<Alert> alerts)
        {
            if (alerts.IsNullOrEmpty())
                return;

            CreateAlertsIfNull();

            Alerts.AddRange(alerts);
        }

        #region Private

        private void CreateAlertsIfNull()
        {
            if (Alerts.IsNullOrEmpty())
                Alerts = new List<Alert>();
        }

        #endregion
    }
}
