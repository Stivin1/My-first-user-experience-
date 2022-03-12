using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers
{
    public class Sorting
    {
        public enum Sort
        {
            EmailAsc,
            EmailDesc,
            UserNameAsc,
            UesrNameDesc
        }

        public Sort Default { get; set; }

        public Sort Email { get; set; }

        public Sort UserName { get; set; }
    }
}
