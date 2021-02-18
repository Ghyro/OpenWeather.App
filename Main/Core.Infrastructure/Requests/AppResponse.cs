using System.Collections.Generic;


namespace Core
{
    using Core.Infrastructure;

    public abstract class AppResponse : IHasId, IAlertContainer
    {
        public string Id { get; set; }

        public string RequestId { get; set; }

        public string ActionId { get; set; }
       
        public List<Alert> Alerts { get; set; }

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
