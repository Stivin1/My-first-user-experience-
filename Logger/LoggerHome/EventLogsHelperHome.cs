using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Logger.LoggerHome
{
    public class EventLogsHelperHome
    {
        public static EventId EventRequestHomeInfo = new EventId(1000, "EventRequestInfo");

        public static EventId EventRequestHomeErrorInfo = new EventId(1001, "EventRequestHomeErrorInfo");
    }
}
