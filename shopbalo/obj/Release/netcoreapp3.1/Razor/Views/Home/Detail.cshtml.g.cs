#pragma checksum "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2b3587dc89d0528302f1c2f491561fc650034e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\_ViewImports.cshtml"
using shopbalo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\_ViewImports.cshtml"
using shopbalo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\_ViewImports.cshtml"
using shopbalo.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2b3587dc89d0528302f1c2f491561fc650034e", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ecd5d7f5776e06331d9f14f9d6feab5c1a6f49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80%;height:80%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
  
    ViewBag.Title = "Detail";
    var categoryname = categoryRepository.Get(Model.balo.CategoryId).CategoryName;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"margin-top:260px;margin-bottom:140px\">\r\n\r\n        <div class=\"col-sm-9\" style=\"border:2px solid;\">\r\n            <h4 class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2b3587dc89d0528302f1c2f491561fc650034e5661", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" >> Sản phẩm >> ");
#nullable restore
#line 10 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                                                 Write(categoryname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <hr />\r\n            <div style=\"margin:50px;\">\r\n                <h2 class=\"mb-3\">");
#nullable restore
#line 13 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                            Write(Model.balo.BaloName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-6\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da2b3587dc89d0528302f1c2f491561fc650034e7819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 671, "~/images/balos/", 671, 15, true);
#nullable restore
#line 16 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 686, Model.balo.Image, 686, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                         if (Model.balo.Sale > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row mt-3\">\r\n                                <h5 class=\"col-6 float-sm-left\">Giá KM: <span style=\"color:red\">");
#nullable restore
#line 20 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                                            Write(Model.balo.Price- Model.balo.Price* Model.balo.Sale/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                                <h5 class=\"col-6 float-sm-right\" style=\"text-decoration:line-through\">");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                                                 Write(Model.balo.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5>Giá : <span style=\"color:red\">");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                         Write(Model.balo.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-sm-6 pl-sm-3\">\r\n                        <p style=\"color:red;\">Miêu tả :</p>\r\n                        <p>Hãng sản xuất: ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                     Write(Model.balo.Trademark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Kích thước: ");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                  Write(Model.balo.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Chất liệu: ");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                 Write(Model.balo.Material);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                         if (Model.balo.Description != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                          Write(Model.balo.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Màu sắc: ");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                               Write(Model.balo.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                         if (Model.balo.Sale > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3 style=\"color:red\">Sale:   ");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                     Write(Model.balo.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h3>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <hr />
                        <h4>Mua ngay:</h4>
                        <div class=""row  pl-sm-3"">
                            <h5>Số lượng:    <input type=""number"" value=""1"" min=""1"" style=""width:60px;height:40px;font-size:30px;text-align:center"" /></h5>
                            <a class=""btn btn-success"" style=""margin-left:auto;""><i class=""fa fa-cart-plus fa-3x""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-3"">
            <table border=""2"">
                <tr>
                    <th colspan=""2"" style=""text-align:center"">
                        <h4> Sản phẩm ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                 Write(categoryname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                 if (Model.balos != null)
                {
                    foreach (Balo balo in Model.balos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"mb-1\">\r\n                            <td style=\"width:40%;height:100px\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2b3587dc89d0528302f1c2f491561fc650034e15925", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da2b3587dc89d0528302f1c2f491561fc650034e16142", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3310, "~/images/balos/", 3310, 15, true);
#nullable restore
#line 66 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 3325, balo.Image, 3325, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                               WriteLiteral(balo.BaloId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da2b3587dc89d0528302f1c2f491561fc650034e19980", async() => {
                WriteLiteral("\r\n                                    <p style=\"font-size: 12px;margin-bottom:5px;\">");
#nullable restore
#line 70 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                             Write(balo.BaloName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 71 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                     if (balo.Sale > 0)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p style=\"text-decoration:line-through;font-size:14px;margin-bottom:5px;\">");
#nullable restore
#line 73 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                                                             Write(balo.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        <p style=\"font-size: 14px;margin-bottom:5px;\">Giá KM: <span style=\"color:red\">");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                                                                  Write(balo.Price-balo.Price*balo.Sale/100);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n");
#nullable restore
#line 75 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p style=\"font-size: 14px;margin-bottom:5px;\">Giá : <span style=\"color:red\">");
#nullable restore
#line 78 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                                                               Write(balo.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                                                                               WriteLiteral(balo.BaloId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Admin\Desktop\CaseStudy\shopbalo\shopbalo\Views\Home\Detail.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICategoryRepository categoryRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewHome> Html { get; private set; }
    }
}
#pragma warning restore 1591
