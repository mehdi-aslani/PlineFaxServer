#pragma checksum "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a166bab293e404af6b20aba9d8fa401a8c1ef03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReceiveFax_Index), @"mvc.1.0.view", @"/Views/ReceiveFax/Index.cshtml")]
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
#line 1 "/home/aslani/Desktop/PlineFaxServer/Views/_ViewImports.cshtml"
using PlineFaxServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/aslani/Desktop/PlineFaxServer/Views/_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
using PlineFaxServer.Tools;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a166bab293e404af6b20aba9d8fa401a8c1ef03", @"/Views/ReceiveFax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047e8389d513b350959d116d2cdad7ba450ae0f4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ReceiveFax_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PlineFaxServer.Models.TblReceiveFax>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>لیست فکس های دریافتی</h3>\r\n<hr/>\r\n<style type=\"text/css\">\r\n    .gCol{\r\n        text-align: center;\r\n    }\r\n    .text-warning,.text-danger{\r\n        font-size: 15pt;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 23 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.Date).Titled("تاریخ دریافت");
        columns.Add(model => model.Time).Titled("ساعت دریافت");
        columns.Add(model => model.Line).Titled("شماره فکس");
        columns.Add().Titled("فایل دریافتی").RenderedAs(model =>
            Html.ActionLink(model.FileName, "DownloadFile", "ReceiveFax", new {id = model.Id})
            );
        columns.Add(model => model.Status).Titled("وضعیت ارسال").RenderedAs(model =>
        {
            return model.Status switch
            {
                Globals.FaxStatus.Received => "فکس دریافت شده",
                Globals.FaxStatus.Archive => "آرشیو شده",
                Globals.FaxStatus.Delete => "حذف شده",
                _ => "نامشخص"
                };
        });
        columns.Add().Titled("عملیات").Encoded(false).RenderedAs(model =>
                model.Status switch
                {
                    Globals.FaxStatus.Received =>  PlineHelper.ActiveLinkAjax($"javascript:SetStatus({model.Id},'{@Globals.FaxStatus.Archive}');", "<i class=\"bi bi-exclamation-octagon\"></i>",
                        "text-warning", "آرشیو فکس") ,
                    Globals.FaxStatus.Recycle => PlineHelper.ActiveLinkAjax($"javascript:SetStatus({model.Id},'{@Globals.FaxStatus.Delete}');", "<i class=\"bi bi-trash\"></i>",
                        "text-danger", "حذف فکس"),
                    _=> PlineHelper.ActiveLinkAjax($"javascript:SetStatus({model.Id},'{@Globals.FaxStatus.Recycle}');", "<i class=\"bi bi-trash\"></i>",
                        "text-danger", "انتقال به سطل زباله")
                }
            );
        })
    .Pageable(pager =>
    {
        pager.PageSizes = new Dictionary<Int32, String> {{0, "All"}, {10, "10"}, {20, "20"}};
        pager.ShowPageSizes = true;
        pager.PagesToDisplay = 3;
        pager.CurrentPage = 4;
        pager.RowsPerPage = 15;
    })
    .Empty("هیچ فکس وجود ندارد")
    .Sortable()
    .Filterable()
    .Css("gCol")
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    function SetStatus(id,status){\r\n        if ((status==\"");
#nullable restore
#line 71 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
                 Write(Globals.FaxStatus.Delete);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" || status==\"");
#nullable restore
#line 71 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
                                                        Write(Globals.FaxStatus.Recycle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") \r\n            && confirm(\"برای حذف این فکس مطمئن هستید؟\")==false ){\r\n               return;\r\n        }\r\n        \r\n        var token=\"");
#nullable restore
#line 76 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
              Write(GetAntiXsrfRequestToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        $.post(\"");
#nullable restore
#line 77 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
           Write(Url.Action("Status", "ReceiveFax"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",{status : status, id : id , __RequestVerificationToken:token},\r\n            function (data){\r\n                if (data.result === false){\r\n                    showMyToast(");
#nullable restore
#line 80 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
                           Write(Globals.ToastError);

#line default
#line hidden
#nullable disable
            WriteLiteral(",data.error);\r\n                }else {\r\n                    location.reload();\r\n                }\r\n        },\"JSON\");\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "/home/aslani/Desktop/PlineFaxServer/Views/ReceiveFax/Index.cshtml"
           
    private string GetAntiXsrfRequestToken()
    {
        return _xsrf.GetAndStoreTokens(Context).RequestToken;
    }

#line default
#line hidden
#nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery _xsrf { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PlineFaxServer.Models.TblReceiveFax>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
