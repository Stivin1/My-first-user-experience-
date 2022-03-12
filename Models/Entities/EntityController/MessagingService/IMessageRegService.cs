

using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Entities.EntityController
{
    public interface IMessageRegService
    {
        Task<int> RegistrationInformation(User user);
    }
}
