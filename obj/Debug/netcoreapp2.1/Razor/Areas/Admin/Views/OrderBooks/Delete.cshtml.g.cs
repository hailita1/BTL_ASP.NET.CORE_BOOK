#pragma checksum "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c647c31ef6d7351d44557a3dce4b3f6b3e7ace06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OrderBooks_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/OrderBooks/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/OrderBooks/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_OrderBooks_Delete))]
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
#line 1 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\_ViewImports.cshtml"
using IBook;

#line default
#line hidden
#line 2 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\_ViewImports.cshtml"
using IBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c647c31ef6d7351d44557a3dce4b3f6b3e7ace06", @"/Areas/Admin/Views/OrderBooks/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb8d79cc55e8c84abb48d470ffb9bcac4254c0f", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_OrderBooks_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IBook.Models.OrderBook>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 275, true);
            WriteLiteral(@"
<h1 class=""text-danger"">Xóa đơn hàng</h1>
<h3>Chắc chắn muốn xóa đơn hàng này?</h3>
<div class=""p-5 border rounded"">
    <h4>Đơn hàng</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <div class=""form-group row"">
            <dt class=""col-2"">
                ");
            EndContext();
            BeginContext(410, 48, false);
#line 16 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(458, 70, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n                ");
            EndContext();
            BeginContext(529, 44, false);
#line 19 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(573, 123, true);
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <dt class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(697, 51, false);
#line 24 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(748, 70, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n                ");
            EndContext();
            BeginContext(819, 47, false);
#line 27 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayFor(model => model.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(866, 123, true);
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <dt class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(990, 51, false);
#line 32 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 70, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n                ");
            EndContext();
            BeginContext(1112, 47, false);
#line 35 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CustomerAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 123, true);
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <dt class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(1283, 49, false);
#line 40 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 70, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n                ");
            EndContext();
            BeginContext(1403, 45, false);
#line 43 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CustomerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 123, true);
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <dt class=\"col-2\">\r\n                ");
            EndContext();
            BeginContext(1572, 47, false);
#line 48 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.isConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 70, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-10\">\r\n                ");
            EndContext();
            BeginContext(1690, 43, false);
#line 51 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
           Write(Html.DisplayFor(model => model.isConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 54, true);
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1787, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93f116ad0aee4c8d865314224ff33511", async() => {
                BeginContext(1813, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1823, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66c2c2dc299848a9ab2adc4c129774da", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 57 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\OrderBooks\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1864, 78, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
                BeginContext(1942, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d893971a7f7545509a6c204da42850f2", async() => {
                    BeginContext(1988, 7, true);
                    WriteLiteral("Quay về");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1999, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2012, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IBook.Models.OrderBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
