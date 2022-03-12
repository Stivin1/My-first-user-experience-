using Microsoft.AspNetCore.Http;
using OpenSourceEnity.Models.Entities.SystemEntities;
using OpenSourceEnity.Models.Service.ServiceSession;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.Service.ServiceMiddleware.AuthenticationMiddleware
{
    public class AuthenUserRequestMiddleware
    {
        private RequestDelegate Request { get; set; }

        public AuthenUserRequestMiddleware(RequestDelegate Request)
        {
            this.Request = Request;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            User user = httpContext.Session.Get<User>(".AspApplicationUser.A009S230S12E");

            if (httpContext.Request.Path.ToString() == "/ListUser")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Role/RoleAppendUser")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Team/TeamUserCreate")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Team/TeamUserCreate")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Home/UserUpdate")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Home/UpdateParticipant")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Role/RoleCreate")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Team/TeamCreate")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Message/UserListMessage")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Message/UserMessage")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Message/ReceivingMessage")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else if (httpContext.Request.Path.ToString() == "/Message/UserReadMessage")
            {
                if (user.Id != null && httpContext.Request.Query["UserId"] != user.Id && httpContext.Request.Query.ContainsKey("UserId"))
                {
                    await httpContext.Response.WriteAsync("<h1>Close Page</h1>");
                }
                else
                {
                    await Request.Invoke(httpContext);
                }
            }
            else
            {
                await Request.Invoke(httpContext);
            }

        }
    }
}
