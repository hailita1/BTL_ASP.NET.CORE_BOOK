#pragma checksum "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c42eab3e1641a787ffdaba79551b7af2fe4193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Details.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Details))]
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
#line 1 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\_ViewImports.cshtml"
using IBook;

#line default
#line hidden
#line 2 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\_ViewImports.cshtml"
using IBook.Models;

#line default
#line hidden
#line 2 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
using IBook.Extensions;

#line default
#line hidden
#line 3 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c42eab3e1641a787ffdaba79551b7af2fe4193", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb8d79cc55e8c84abb48d470ffb9bcac4254c0f", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IBook.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Remove from bag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Add to bag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Customer/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(244, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(252, 9115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99dc0f96a40b452ea9679fade68f4cf8", async() => {
                BeginContext(272, 268, true);
                WriteLiteral(@"
    <div class=""p-5 border rounded"">
        <div class=""form-group row "">
            <div class=""col-1""></div>
            <div class=""col-4"" style=""width:340px; height:497px;"">
                    <img class=""img-responsive"" style=""width:340px; height:497px;""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 540, "\"", 561, 1);
#line 17 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 546, Model.ImageUrl, 546, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(562, 181, true);
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-1\">\r\n            </div>\r\n            <div class=\"col-5\">\r\n\r\n                <div class=\"product-name\">\r\n                    <h1>");
                EndContext();
                BeginContext(744, 11, false);
#line 24 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(755, 231, true);
                WriteLiteral("</h1>\r\n                </div>\r\n                <span class=\"sku_wrapper\">\r\n                    <span class=\"item-title\">Mã sản phẩm:</span>\r\n                    <span>\r\n                        <strong>\r\n                            ");
                EndContext();
                BeginContext(987, 11, false);
#line 30 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(998, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1002, 12, false);
#line 30 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                      Write(Model.BookID);

#line default
#line hidden
                EndContext();
                BeginContext(1014, 235, true);
                WriteLiteral("\r\n                        </strong>\r\n                    </span>\r\n                </span>\r\n                <span><br /></span>\r\n                <span class=\"category-url-wrapper\">\r\n                    <span class=\"item-title\">Tác giả: ");
                EndContext();
                BeginContext(1250, 17, false);
#line 36 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                                 Write(Model.Author.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1267, 166, true);
                WriteLiteral("</span>\r\n                </span>\r\n                <br />\r\n                <span class=\"category-url-wrapper\">\r\n                    <span class=\"item-title\">Thể loại: ");
                EndContext();
                BeginContext(1434, 19, false);
#line 40 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                                  Write(Model.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1453, 170, true);
                WriteLiteral("</span>\r\n                </span>\r\n                <br />\r\n                <span class=\"category-url-wrapper\">\r\n                    <span class=\"item-title\">Nhà xuất bản: ");
                EndContext();
                BeginContext(1624, 20, false);
#line 44 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                                      Write(Model.Publisher.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1644, 553, true);
                WriteLiteral(@"</span>
                </span>
                <div class=""short-description"">
                    <div class=""std"">
                        <h5>

                            <strong></strong>

                        </h5><br>

                    </div>
                </div>

                <p class=""availability in-stock"">
                    <span class=""item-title"">
                        <i>Còn lại: </i>
                    </span>
                    <span>
                        <strong>
                            ");
                EndContext();
                BeginContext(2198, 16, false);
#line 63 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                       Write(Model.Quantities);

#line default
#line hidden
                EndContext();
                BeginContext(2214, 186, true);
                WriteLiteral("\r\n                        </strong>\r\n                    </span>\r\n                    trong kho\r\n                </p>\r\n                <div class=\"price-box\">\r\n\r\n                    <h3>");
                EndContext();
                BeginContext(2401, 11, false);
#line 70 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2412, 203, true);
                WriteLiteral(" VNĐ</h3>\r\n\r\n\r\n                </div>\r\n                <div class=\"add-to-box\">\r\n                    <div class=\"add-to-cart nn-margin-bottom\">\r\n\r\n                    </div>\r\n                    <br />\r\n");
                EndContext();
#line 79 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                      
                        bool isInBag = false;
                        List<int> lstCart = HttpContextAccessor.HttpContext.Session.Get<List<int>>("ssShoppingCart");
                        if (lstCart != null && lstCart.Contains(Model.BookID))
                        {
                            isInBag = true;
                        }
                    

#line default
#line hidden
                BeginContext(3007, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 87 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                     if (Model.Quantities != 0)
                    {
                        

#line default
#line hidden
#line 89 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                         if (isInBag)
                        {

#line default
#line hidden
                BeginContext(3145, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(3173, 157, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b856411601d546169f45dd034a2a0990", async() => {
                    BeginContext(3304, 17, true);
                    WriteLiteral("Xóa khỏi giỏ hàng");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 91 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                                                                                WriteLiteral(Model.BookID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3330, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 92 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(3416, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(3444, 133, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "699b700a134b4a1283f6941f0ee62d6e", async() => {
                    BeginContext(3551, 17, true);
                    WriteLiteral("Thêm vào giỏ hàng");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 95 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                                                       WriteLiteral(Model.BookID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3577, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 96 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
#line 96 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(3678, 88, true);
                WriteLiteral("                        <label class=\"btn btn-danger form-control\">Đã hết hàng</label>\r\n");
                EndContext();
#line 101 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                    }

#line default
#line hidden
                BeginContext(3789, 1140, true);
                WriteLiteral(@"
                </div>


            </div>
            <div class=""col-1"">
            </div>
        </div>
        <br />
        <div>
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li class=""active"">
                    <a href=""#descriptions"" role=""tab"" data-toggle=""tab"">
                        Tóm tắt
                    </a>
                </li>
                <li style=""width:15px;""></li>
                <li>
                    <a href=""#specifications"" role=""tab"" data-toggle=""tab"">
                        Thông tin chi tiết
                    </a>
                </li>
                <li style=""width:15px;""></li>
                <li>
                    <a href=""#comments"" role=""tab"" data-toggle=""tab"">
                        <i class=""fa fa-envelope""></i> Bình puận
                    </a>
                </li>

            </ul>

            <div class=""tab-content"" style=""font-size:23px;"">
                <div class=""tab-pane fade acti");
                WriteLiteral("ve in\" id=\"descriptions\">\r\n                    <h2>Tóm tắt</h2>\r\n                    <div>\r\n                        ");
                EndContext();
                BeginContext(4930, 13, false);
#line 137 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                   Write(Model.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(4943, 539, true);
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""tab-pane fade row"" id=""specifications"">
                    <h2>Chi tiết sản phẩm</h2>
                    <div class=""col-md-12"">
                        <table class=""table table-hover table-striped table-bordered"">
                            <tr>
                                <td>
                                    Mã sản phẩm:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(5483, 11, false);
#line 149 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(5494, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(5498, 12, false);
#line 149 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                                              Write(Model.BookID);

#line default
#line hidden
                EndContext();
                BeginContext(5510, 308, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tên sách:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(5819, 11, false);
#line 157 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(5830, 308, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Số trang:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(6139, 19, false);
#line 165 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.NumberOfPages);

#line default
#line hidden
                EndContext();
                BeginContext(6158, 322, true);
                WriteLiteral(@" trang luôn bìa
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tác giả:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(6481, 17, false);
#line 173 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Author.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6498, 308, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Thể loại:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(6807, 19, false);
#line 181 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Category.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6826, 312, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nhà xuất bản:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(7139, 20, false);
#line 189 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Publisher.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7159, 312, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Số lượng còn:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(7472, 16, false);
#line 197 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Quantities);

#line default
#line hidden
                EndContext();
                BeginContext(7488, 319, true);
                WriteLiteral(@" quyển
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ngày xuất bản:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(7808, 36, false);
#line 205 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.CreateDate.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(7844, 312, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ngày tái bản:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(8157, 38, false);
#line 213 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.ModifiedDate.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(8195, 307, true);
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Giá bán:
                                </td>
                                <td>
                                    ");
                EndContext();
                BeginContext(8503, 11, false);
#line 221 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
                               Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(8514, 413, true);
                WriteLiteral(@" VNĐ
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class=""col-md-6""></div>


                </div>
                <div class=""tab-pane fade"" id=""comments"">
                    <h2>Tính năng hiện đang phát triển, quý khách vui lòng quay lại sau! Trân trọng xin lỗi vì sự bất tiện này!</h2>
");
                EndContext();
                BeginContext(9109, 110, true);
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(9219, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54f682fbfe2c4171a90483b169e53f3a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 239 "C:\Users\Phantom\Desktop\Website bán sách online\DoAnWeb - Final\IBook\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BookID);

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
                BeginContext(9259, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(9273, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a11730a14b4115a501a5549197fc5e", async() => {
                    BeginContext(9319, 7, true);
                    WriteLiteral("Quay về");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9330, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
