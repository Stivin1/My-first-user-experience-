using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserMessageControllerHelpers
{
    public class ListUserMessageSorting : Sorting
    {
        public ListUserMessageSorting(Sort sort)
        {
            Default = sort;
            Email = sort == Sort.EmailAsc ? Sort.EmailDesc : Sort.EmailAsc;
            UserName = sort == Sort.UserNameAsc ? Sort.UesrNameDesc : Sort.UserNameAsc;
        }

        public IEnumerable<User> UserSorting(IEnumerable<User> users, Sort sorting)
        {
            switch (sorting)
            {
                case Sort.EmailAsc:
                    users = users.OrderBy(t => t.Email); break;
                case Sort.EmailDesc:
                    users = users.OrderByDescending(t => t.Email); break;
                case Sort.UserNameAsc:
                    users = users.OrderBy(s => s.UserName); break;
                case Sort.UesrNameDesc:
                    users = users.OrderByDescending(t => t.UserName); break;
                default: throw new Exception("Error sorting");
            }

            return users;
        }
    }
}
