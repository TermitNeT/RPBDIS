#pragma checksum "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0159a1d2ffa28d1b3ed4bdfe88bd660fd2f7e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workers_Index), @"mvc.1.0.view", @"/Views/Workers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Workers/Index.cshtml", typeof(AspNetCore.Views_Workers_Index))]
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
#line 1 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using CourseWork;

#line default
#line hidden
#line 2 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using CourseWork.Models;

#line default
#line hidden
#line 2 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
using CourseWork.pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0159a1d2ffa28d1b3ed4bdfe88bd660fd2f7e6", @"/Views/Workers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf70ce142b2c8e1070383ff6d97537d03c63b95", @"/Views/_ViewImports.cshtml")]
    public class Views_Workers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
  
    ViewData["Title"] = "Работники";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 33, true);
            WriteLiteral("\r\n<h1>Работники</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(175, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f2015c25a5849918ac827224b5c4ca4", async() => {
                BeginContext(222, 25, true);
                WriteLiteral("Добавить нового работника");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(251, 12, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
 using (Html.BeginForm("Index", "Workers", FormMethod.Get))
{

#line default
#line hidden
            BeginContext(327, 35, true);
            WriteLiteral("<fieldset>\r\n    Фамилия работника: ");
            EndContext();
            BeginContext(363, 38, false);
#line 19 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                  Write(Html.TextBox("Surname", Model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(401, 21, true);
            WriteLiteral("\r\n    Имя работника: ");
            EndContext();
            BeginContext(423, 32, false);
#line 20 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
              Write(Html.TextBox("Name", Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(455, 17, true);
            WriteLiteral("\r\n    Должность: ");
            EndContext();
            BeginContext(473, 40, false);
#line 21 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
          Write(Html.TextBox("Position", Model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(513, 58, true);
            WriteLiteral("\r\n    <input type=\"submit\" value=\"Найти\" />\r\n</fieldset>\r\n");
            EndContext();
#line 24 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(574, 740, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
                Фамилия
            </th>
            <th>
                Имя
            </th>
            <th>
                Отчество
            </th>
            <th>
                Возраст
            </th>
            <th>
                Пол
            </th>
            <th>
                Адрес
            </th>
            <th>
                Телефон
            </th>
            <th>
                Паспортные данные
            </th>
            <th>
                Должность
            </th>
            <th>
                Бригада
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 63 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
         foreach (var item in Model.workers)
        {

#line default
#line hidden
            BeginContext(1371, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1432, 42, false);
#line 67 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1542, 39, false);
#line 70 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1649, 45, false);
#line 73 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1762, 38, false);
#line 76 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1868, 38, false);
#line 79 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1974, 41, false);
#line 82 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2083, 40, false);
#line 85 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2123, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2191, 43, false);
#line 88 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Passport));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2302, 56, false);
#line 91 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Position.PositionName));

#line default
#line hidden
            EndContext();
            BeginContext(2358, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2426, 48, false);
#line 94 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Team.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2541, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eca83441c4524790b1b8ce573353ae6b", async() => {
                BeginContext(2616, 13, true);
                WriteLiteral("Редактировать");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                                                                   WriteLiteral(item.WorkerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2633, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2657, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d809ee38ab94eb7956f22a4b86c6da8", async() => {
                BeginContext(2735, 6, true);
                WriteLiteral("Детали");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                                                                      WriteLiteral(item.WorkerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2745, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2769, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5d7429b9b5424b81e6a374cc32b893", async() => {
                BeginContext(2846, 7, true);
                WriteLiteral("Удалить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                                                                     WriteLiteral(item.WorkerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2857, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 102 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2912, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 105 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
 if (Model.PageViewModel.HasPreviousPage)
{

#line default
#line hidden
            BeginContext(2982, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2986, 437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c69556c48cd04ad4868dc0df5ecbcf20", async() => {
                BeginContext(3340, 79, true);
                WriteLiteral("\r\n        <i class=\"glyphicon glyphicon-chevron-left\"></i>\r\n        Назад\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
            WriteLiteral(Model.PageViewModel.PageNumber - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 109 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               WriteLiteral(Model.FilterViewModel.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                   WriteLiteral(Model.FilterViewModel.Surname);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Surname"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Surname", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Surname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 111 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.Position);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Position"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Position", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Position"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
           WriteLiteral(ViewBag.CurrentState);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sort"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sort", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sort"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3423, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 117 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
}

       

#line default
#line hidden
            BeginContext(3708, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 123 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
     if (Model.PageViewModel.HasNextPage)
    {

#line default
#line hidden
            BeginContext(3760, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3768, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff361eb419f4f1c952d019dc4616127", async() => {
                BeginContext(4156, 93, true);
                WriteLiteral("\r\n            Вперед\r\n            <i class=\"glyphicon glyphicon-chevron-right\"></i>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 126 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                WriteLiteral(Model.PageViewModel.PageNumber + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 127 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                   WriteLiteral(Model.FilterViewModel.Surname);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Surname"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Surname", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Surname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 128 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               WriteLiteral(Model.FilterViewModel.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 129 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
                    WriteLiteral(Model.FilterViewModel.Position);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Position"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Position", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Position"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 130 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
               WriteLiteral(ViewBag.CurrentState);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sort"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sort", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sort"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4253, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 135 "C:\Users\Nikol\source\repos\WebApplication1\WebApplication1\Views\Workers\Index.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
