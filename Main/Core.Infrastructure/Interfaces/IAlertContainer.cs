using System.Collections.Generic;

namespace Core
{
    using Core.Infrastructure;

    public interface IAlertContainer
    {
        List<Alert> Alerts { get; set; }

        void AddAlerts(IEnumerable<Alert> alerts);
    }
}
