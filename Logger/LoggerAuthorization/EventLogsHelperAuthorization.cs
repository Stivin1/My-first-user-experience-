using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenSourceEnity.Logger.LoggerAuthorization
{
    public class EventLogsHelperAuthorization
    {
        public static EventId EventRequestAutInfo = new EventId(1000, "EventRequestAutInfo");

        public static EventId EventRequestAutErrorInfo = new EventId(1001, "EventRequestAutErrorInfo");
    }
}
