#pragma checksum "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8680192e00cfa97ea24dfd525f75f39274c08b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8680192e00cfa97ea24dfd525f75f39274c08b0a", @"/Areas/Admin/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb8d79cc55e8c84abb48d470ffb9bcac4254c0f", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IBook.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:30px; width:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 461, true);
            WriteLiteral(@"
<h2 class=""text-info"">Chi tiết sách</h2>
<div class=""p-5 border rounded"">
    <h4>Sách</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <div class=""row nn-margin-bottom "">
            <div class=""nn-product-image-box col-sm-1"">
            </div>
            <div class=""nn-product-image-box col-sm-4"">
                <div class=""nn-product-image-box-main  "">
                    <img class=""img-responsive"" style=""height:600px; width:400px;""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 589, "\"", 610, 1);
#line 17 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
WriteAttributeValue("", 595, Model.ImageUrl, 595, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(611, 171, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"nn-product-shop col-sm-6\">\r\n\r\n                <div class=\"product-name\">\r\n                    <h1>");
            EndContext();
            BeginContext(783, 11, false);
#line 23 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(794, 276, true);
            WriteLiteral(@"</h1>
                </div>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Tóm tắt: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(1071, 13, false);
#line 30 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 329, true);
            WriteLiteral(@"
                    </span>
                    trong kho
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Tác giả: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(1414, 17, false);
#line 39 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 299, true);
            WriteLiteral(@"
                    </span>
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Thể loại: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(1731, 19, false);
#line 47 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1750, 303, true);
            WriteLiteral(@"
                    </span>
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Nhà xuất bản: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(2054, 20, false);
#line 55 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2074, 299, true);
            WriteLiteral(@"
                    </span>
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Số trang: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(2374, 19, false);
#line 63 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.NumberOfPages);

#line default
#line hidden
            EndContext();
            BeginContext(2393, 340, true);
            WriteLiteral(@"
                    </span>
                    trang luôn bìa
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Ngày xuất bản: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(2734, 36, false);
#line 72 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.CreateDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2770, 303, true);
            WriteLiteral(@"
                    </span>
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Ngày tái bản: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(3074, 38, false);
#line 80 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.ModifiedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3112, 303, true);
            WriteLiteral(@"
                    </span>
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Số lượng còn: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(3416, 16, false);
#line 88 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Quantities);

#line default
#line hidden
            EndContext();
            BeginContext(3432, 335, true);
            WriteLiteral(@"
                    </span>
                    Cuốn trong kho.
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Giá bán: </i>
                    </span>
                    <span>
                        ");
            EndContext();
            BeginContext(3768, 11, false);
#line 97 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3779, 394, true);
            WriteLiteral(@"
                    </span>
                    VNĐ
                </p>
                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i style=""font-size:23px;"">Được phép bán: </i>
                    </span>
                    <span>
                        <label style=""visibility:visible;"">
                            ");
            EndContext();
            BeginContext(4173, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17589f9149f24ea39ec7a45428ae0bd3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 107 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsPurchase);

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
            BeginContext(4245, 247, true);
            WriteLiteral("\r\n                        </label>\r\n                    </span>\r\n                </p>\r\n            </div>\r\n            <div class=\"nn-product-image-box col-sm-1\"></div>\r\n        </div>\r\n    </dl>\r\n    <div class=\"form-group text-center\">\r\n        ");
            EndContext();
            BeginContext(4492, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a29bae385764f138a122691267474e9", async() => {
                BeginContext(4566, 9, true);
                WriteLiteral("Chỉnh sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                                                       WriteLiteral(Model.BookID);

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
            BeginContext(4579, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(4589, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ee4595c42b497899e4a52582760876", async() => {
                BeginContext(4635, 7, true);
                WriteLiteral("Quay về");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4646, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(4656, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27cf2945b1e348a0b0c2f332370f454b", async() => {
                BeginContext(4731, 3, true);
                WriteLiteral("Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Admin\Views\Books\Details.cshtml"
                                                        WriteLiteral(Model.BookID);

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
            BeginContext(4738, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IBook.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
