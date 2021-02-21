using System.Collections.Generic;

namespace Core
{
    public interface IAlertContainer
    {
        List<Alert> Alerts { get; set; }

        void AddAlerts(IEnumerable<Alert> alerts);
    }
}
