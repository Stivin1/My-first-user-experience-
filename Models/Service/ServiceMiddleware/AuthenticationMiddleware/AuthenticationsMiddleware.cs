using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Service.ServiceMiddleware.AuthenticationMiddleware
{
    public class AuthenticationsMiddleware
    {
        private RequestDelegate Request { get; set; }

        public AuthenticationsMiddleware(RequestDelegate Request)
        {
            this.Request = Request;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            await Request.Invoke(httpContext);
        }
    }
}
