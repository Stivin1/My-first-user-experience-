#pragma checksum "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_RoleCreate), @"mvc.1.0.view", @"/Views/Role/RoleCreate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\_ViewImports.cshtml"
using OpenSourceEnity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\_ViewImports.cshtml"
using OpenSourceEnity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c45268b05d93dc774a6d300fa26a6ac7bbe0a58e", @"/Views/Role/RoleCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b431a70cc7812a70f8a0731dbda4eb3a09a34714", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_RoleCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpenSourceEnity.Models.ModelViews.EntityViews.RoleCreate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/RoleAppend.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomeMenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"en\" dir=\"ltr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e6363", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e6657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e7836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e9015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e10921", async() => {
                WriteLiteral("\r\n    <div class=\"list-navigation\">\r\n        <nav>\r\n            <ul>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 472, "\"", 510, 1);
#nullable restore
#line 20 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
WriteAttributeValue("", 479, Url.ActionLink("Index","Home"), 479, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">OpenSource</a></li>\r\n                <li><input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 571, "\"", 578, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 579, "\"", 587, 0);
                EndWriteAttribute();
                WriteLiteral("></li>\r\n                <li class=\"container-li\">");
#nullable restore
#line 22 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                                    Write(Html.ActionLink("Выход", "Logout", "Home", null, new { @class = "container-thref-a" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                <li><a href=""#"">О сайте</a></li>
                <li><a href=""#"">Контакты</a></li>
            </ul>
        </nav>
    </div>
    <div class=""base"">
        <div class=""container-home"">
            <div class=""container-home-menu"">
                <nav>
                    <ul>
                        <li>");
#nullable restore
#line 33 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Моя страница", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 34 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Список пользователей", "Index", "ListUser", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 35 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Добавить роль пользователю", "RoleAppendUser", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 36 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Добавить группу пользователю", "TeamUserCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 37 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Обновить учетные данные", "UserUpdate", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 38 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Обновить пользовательские данные", "UpdateParticipant", "Home", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 39 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Добавить роль", "RoleCreate", "Role", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 40 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Добавить группу", "TeamCreate", "Team", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 41 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Отправить сообщения", "UserListMessage", "Message", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 42 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                       Write(Html.ActionLink("Прочитать сообщения", "ReceivingMessage", "Message", new { UserId = Model.UserId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                    </ul>
                </nav>
            </div>
        </div>
        <div class=""information"">
            <div class=""container-home-base"">
                <div class=""info"">
                    Добавить роль
                </div>
                <div class=""container-location"">
                    <div class=""container-base-account"">
                        <div class=""container-account"">
                            <div class=""container-info-account"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 2852, "\"", 2858, 0);
                EndWriteAttribute();
                WriteLiteral(">Добавить роль</label>\r\n                            </div>\r\n                            <div class=\"container-account\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45268b05d93dc774a6d300fa26a6ac7bbe0a58e17179", async() => {
                    WriteLiteral("\r\n                                    ");
#nullable restore
#line 60 "D:\Программы\Мои проекты\ASPN\Проекты\OpenSourceEnity\Views\Role\RoleCreate.cshtml"
                               Write(Html.Hidden("UserId",Model.UserId));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    <div class=\"container-label\">\r\n                                        <label");
                    BeginWriteAttribute("for", " for=\"", 3266, "\"", 3272, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Наименование роль</label>\r\n                                    </div>\r\n                                    <div class=\"container-part-input\">\r\n                                        <input type=\"text\" name=\"RoleName\"");
                    BeginWriteAttribute("value", " value=\"", 3491, "\"", 3499, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    </div>\r\n                                    <div");
                    BeginWriteAttribute("class", " class=\"", 3587, "\"", 3595, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        <div class=\"container-reg\">\r\n                                            <input type=\"submit\"");
                    BeginWriteAttribute("name", " name=\"", 3732, "\"", 3739, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Добавить роль\">\r\n                                        </div>\r\n                                    </div>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenSourceEnity.Models.ModelViews.EntityViews.RoleCreate> Html { get; private set; }
    }
}
#pragma warning restore 1591