using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace OpenSourceEnity.Logger.LoggerMapper
{
    [Serializable]
    public class LoggerMapperUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string DateOperation { get; set; }

        public string DescriptionOperation { get; set; }
    }
}
