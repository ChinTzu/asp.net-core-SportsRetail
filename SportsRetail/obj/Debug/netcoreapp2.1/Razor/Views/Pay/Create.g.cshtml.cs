#pragma checksum "D:\CSharp\MVC\SportsRetail\SportsRetail\Views\Pay\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d3d5a83d9e2950b99edbd2633e605a34000f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pay_Create), @"mvc.1.0.view", @"/Views/Pay/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pay/Create.cshtml", typeof(AspNetCore.Views_Pay_Create))]
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
#line 1 "D:\CSharp\MVC\SportsRetail\SportsRetail\Views\_ViewImports.cshtml"
using SportsRetail.ViewModels;

#line default
#line hidden
#line 2 "D:\CSharp\MVC\SportsRetail\SportsRetail\Views\_ViewImports.cshtml"
using SportsRetail.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d3d5a83d9e2950b99edbd2633e605a34000f78", @"/Views/Pay/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6fc37c4b6149b69938bc6d05765d9f991f800f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pay_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\CSharp\MVC\SportsRetail\SportsRetail\Views\Pay\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(40, 181, true);
            WriteLiteral("\r\n<script src=\"https://js.stripe.com/v3/\"></script>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 col-sm-offset-3\">\r\n            <h2>Total Price : ");
            EndContext();
            BeginContext(222, 32, false);
#line 11 "D:\CSharp\MVC\SportsRetail\SportsRetail\Views\Pay\Create.cshtml"
                         Write(ViewBag.totalPrice.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(254, 22, true);
            WriteLiteral(" </h2>\r\n\r\n            ");
            EndContext();
            BeginContext(276, 2414, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50bfecc7872847d9b0ee4b2082894b3e", async() => {
                BeginContext(330, 2123, true);
                WriteLiteral(@"

                <div class=""form-group"">
                    <label for=""card-name"">Card Name</label>
                    <input type=""text"" name=""cardName"" class=""form-control"" id=""card-name"" placeholder=""card name"">
                </div>

                <div class=""form-group"">
                    <label for=""email"">Email</label>
                    <input type=""email"" name=""email"" class=""form-control"" id=""email"" placeholder=""Email"">
                </div>

                <div class=""form-group"">
                    <label for=""phone"">Phone number</label>
                    <input type=""tel"" name=""phone"" class=""form-control"" id=""phone"" placeholder=""phone number"">
                </div>

                <div class=""form-group"">
                    <label for=""card-number"">
                        Credit or debit card
                    </label>
                    <div id=""card-number"">
                        <!-- A Stripe Element will be inserted here. -->
                    ");
                WriteLiteral(@"</div>
                </div>

                <div class=""form-group"">
                    <div class=""row"">

                        <div class=""col-md-6"">
                            <label for=""card-cvc"">
                                CVC
                            </label>
                            <div id=""card-cvc"">
                                <!-- A Stripe Element will be inserted here. -->
                            </div>
                        </div>

                        <div class=""col-md-6"">

                            <label for=""card-exp"">
                                Expired
                            </label>
                            <div id=""card-exp"">
                                <!-- A Stripe Element will be inserted here. -->
                            </div>

                        </div>
                    </div>
                </div>

                <!-- Used to display form errors. -->
                <div id=""card-errors"" ro");
                WriteLiteral("le=\"alert\"></div>\r\n\r\n                <!-- Total price -->\r\n                ");
                EndContext();
                BeginContext(2454, 53, false);
#line 68 "D:\CSharp\MVC\SportsRetail\SportsRetail\Views\Pay\Create.cshtml"
           Write(Html.Hidden("totalPrice", (object)ViewBag.totalPrice));

#line default
#line hidden
                EndContext();
                BeginContext(2507, 176, true);
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    <button class=\"form-control btn btn-primary\">Submit Payment</button>\r\n                </div>\r\n\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(2690, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
