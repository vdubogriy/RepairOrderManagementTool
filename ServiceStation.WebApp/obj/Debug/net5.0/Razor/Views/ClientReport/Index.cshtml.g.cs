#pragma checksum "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7ee8845b7201837682623a4ce032e35a6a4b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientReport_Index), @"mvc.1.0.view", @"/Views/ClientReport/Index.cshtml")]
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
#line 1 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\_ViewImports.cshtml"
using ServiceStation.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\_ViewImports.cshtml"
using ServiceStation.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7ee8845b7201837682623a4ce032e35a6a4b7d", @"/Views/ClientReport/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77cead64f67c39ad9c2e2f726cac1812223fb443", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ClientReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateRangeModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/servicestation.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script src=\"https://code.jquery.com/jquery-3.7.1.js\"></script>\r\n<script src=\"https://code.jquery.com/ui/1.14.1/jquery-ui.js\"></script>\r\n<link rel=\"stylesheet\" href=\"https://code.jquery.com/ui/1.14.1/themes/base/jquery-ui.css\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f7ee8845b7201837682623a4ce032e35a6a4b7d4620", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f7ee8845b7201837682623a4ce032e35a6a4b7d5734", async() => {
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"client-report-container\">\r\n    ");
#nullable restore
#line 10 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
Write(Html.Label(null, null, new { @class = "error-message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"label\">");
#nullable restore
#line 11 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
                  Write(Html.Label("ИНН:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"textbox\">");
#nullable restore
#line 12 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
                    Write(Html.TextBox("TaxNumber", null, new { @class = "form-control", @id = "tax" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"label\">");
#nullable restore
#line 13 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
                  Write(Html.Label("Гос номер:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"textbox\">");
#nullable restore
#line 14 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
                    Write(Html.TextBox("LicensePlateNumber", null, new { @class = "form-control", @id = "license" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"label\">");
#nullable restore
#line 15 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
                  Write(Html.Label("Период:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"datepicker-container\">\r\n        ");
#nullable restore
#line 17 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
   Write(Html.TextBoxFor(model => model.DateFrom, Model.DateFrom.ToShortDateString(), new { @class = "form-control", @id = "datepicker-from", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\vasil\Desktop\ServiceStation.API\ServiceStation.API\ServiceStation.WebApp\Views\ClientReport\Index.cshtml"
   Write(Html.TextBoxFor(model => model.DateTo, Model.DateTo.ToShortDateString(), new { @class = "form-control", @id = "datepicker-to", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div style=""clear: both;""</div>
    <div class=""button-container"">
        <button type=""button"" class=""btn btn-primary btn-block mb-4"" onclick=""GenerateReport()"">Сформировать отчет</button>
        <div class=""report-result-container"">
            <div id=""client""></div>
            <div id=""vehicle""></div>
            <div id=""total""></div>
            <div id=""sum""></div>
            <div id=""mileage""></div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('#datepicker-from').datepicker({ dateFormat: 'dd.mm.yy' });
        $('#datepicker-to').datepicker({ dateFormat: 'dd.mm.yy' });
    });
    function GenerateReport() {
        var requetsModel = {
            DateFrom: $('#datepicker-from').datepicker('getDate'),
            DateTo: $('#datepicker-to').datepicker('getDate'),
            TaxNumber: $(""#tax"").val(),
            LicensePlateNumber: $(""#license"").val()
        };        

        $.ajax({
            url: (""");
            WriteLiteral(@"/ClientReport/ReportResult""),
            type: ""POST"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            data: JSON.stringify(requetsModel),
            success: function (response) {
                if (response == null) {
                    $('.error-message').text(""ТС не найдено"");
                    $('#client').empty();
                    $('#vehicle').empty();
                    $('#total').empty();
                    $('#sum').empty();
                    $('#mileage').empty();
                }
                else {
                    $('.error-message').empty();

                    $('#client').text(""Заказчик: "" + response.client.name);
                    $('#vehicle').text(""ТС: "" + response.vehicle.brandModel);
                    $('#total').text(""Кол-во: "" + response.total);
                    $('#sum').text(""Сумма: "" + response.sum);                        
                    $('#mileage').text(""Пробег: "" + respo");
            WriteLiteral("nse.mileage);\r\n                }                \r\n            }\r\n        });        \r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateRangeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
