#pragma checksum "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d60b5fc0756da06ba9d92a9aa3bb98ed317a38b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Grid), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Grid.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/aslani/Desktop/PlineFaxServer/Views/_ViewImports.cshtml"
using PlineFaxServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d60b5fc0756da06ba9d92a9aa3bb98ed317a38b", @"/Views/Shared/MvcGrid/_Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047e8389d513b350959d116d2cdad7ba450ae0f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGrid>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 8 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
  
    IGridRow<Object>[] rows = Model.Rows.ToArray();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div");
            BeginWriteAttribute("id", " id=\"", 208, "\"", 222, 1);
#nullable restore
#line 12 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 213, Model.Id, 213, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 223, "\"", 294, 4);
            WriteAttributeValue("", 231, "mvc-grid", 231, 8, true);
            WriteAttributeValue(" ", 239, "mvc-grid-", 240, 10, true);
#nullable restore
#line 12 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 249, Model.FilterMode.ToString().ToLower(), 249, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 289, "-mode", 289, 5, true);
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 12 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-filter-mode=\"");
#nullable restore
#line 12 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                                                                                 Write(Model.FilterMode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 12 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                                                                                                              Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <");
            WriteLiteral("table");
#nullable restore
#line 13 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
       Write(Model.Attributes);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n        <thead>\n        <tr");
            BeginWriteAttribute("class", " class=\"", 439, "\"", 538, 2);
            WriteAttributeValue("", 447, "mvc-grid-headers", 447, 16, true);
#nullable restore
#line 15 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 463, Model.FilterMode == GridFilterMode.Header ? " mvc-grid-row-filters" : "", 463, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 16 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String applied = (column.Filter.First ?? column.Filter.Second) == null ? "" : " applied";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
#nullable restore
#line 20 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
               Write(column.AsAttributes());

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n");
#nullable restore
#line 21 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                     if (column.Filter.IsEnabled == true && !String.IsNullOrEmpty(column.Filter.Name) && Model.FilterMode != GridFilterMode.Row)
                    {
                        if (Model.FilterMode == GridFilterMode.Header)
                        {
                            String[] values = column.Filter.First?.Values ?? StringValues.Empty;
                            Int32 size = column.Title is String title && title.Length > 0 ? title.Length : 20;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\n");
#nullable restore
#line 29 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                 if (column.Filter.Options.Any())
                                {
                                    values = column.Filter.Options.Where(option => values.Contains(option.Value)).Select(option => option.Text).ToArray();


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 1594, "\"", 1628, 1);
#nullable restore
#line 33 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 1602, String.Join(", ", values), 1602, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("size", " size=\"", 1629, "\"", 1641, 1);
#nullable restore
#line 33 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 1636, size, 1636, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1642, "\"", 1669, 1);
#nullable restore
#line 33 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 1656, column.Title, 1656, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" readonly/>\n");
#nullable restore
#line 34 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 1866, "\"", 1900, 1);
#nullable restore
#line 37 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 1874, String.Join(", ", values), 1874, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("size", " size=\"", 1901, "\"", 1913, 1);
#nullable restore
#line 37 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 1908, size, 1908, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1914, "\"", 1941, 1);
#nullable restore
#line 37 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 1928, column.Title, 1928, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n");
#nullable restore
#line 38 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n");
#nullable restore
#line 40 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"mvc-grid-title\">");
#nullable restore
#line 43 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                    Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 44 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <select class=\"mvc-grid-options\">\n");
#nullable restore
#line 47 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                             foreach (SelectListItem option in column.Filter.Options)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d60b5fc0756da06ba9d92a9aa3bb98ed317a38b11943", async() => {
#nullable restore
#line 49 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                         Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                   WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 50 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\n");
#nullable restore
#line 52 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"

                        if (column.Sort.IsEnabled == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"mvc-grid-sort\">\n                                <span>");
#nullable restore
#line 56 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                  Write(column.Sort.Index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </button>\n");
#nullable restore
#line 58 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 2861, "\"", 2894, 2);
            WriteAttributeValue("", 2869, "mvc-grid-filter", 2869, 15, true);
#nullable restore
#line 60 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 2884, applied, 2884, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\n");
#nullable restore
#line 61 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"mvc-grid-title\">");
#nullable restore
#line 64 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 65 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"

                        if (column.Sort.IsEnabled == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"mvc-grid-sort\">\n                                <span>");
#nullable restore
#line 69 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                  Write(column.Sort.Index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </button>\n");
#nullable restore
#line 71 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\n");
#nullable restore
#line 74 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n");
#nullable restore
#line 76 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
         if (Model.FilterMode == GridFilterMode.Row)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"mvc-grid-row-filters\">\n");
#nullable restore
#line 79 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                 foreach (IGridColumn column in Model.Columns)
                {
                    String hidden = column.IsHidden ? " mvc-grid-hidden" : "";

                    if (column.Filter.IsEnabled == true && !String.IsNullOrEmpty(column.Filter.Name))
                    {
                        String applied = (column.Filter.First ?? column.Filter.Second) == null ? "" : " applied";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th");
            BeginWriteAttribute("class", " class=\"", 3950, "\"", 3998, 3);
            WriteAttributeValue("", 3958, "filterable", 3958, 10, true);
#nullable restore
#line 87 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue(" ", 3968, column.CssClasses, 3969, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 3989, hidden, 3989, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div>\n");
#nullable restore
#line 89 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                 if (column.Filter.Options.Any())
                                {
                                    if (column.Filter.Type == GridFilterType.Multi)
                                    {
                                        String[] values = column.Filter.First?.Values ?? StringValues.Empty;
                                        values = column.Filter.Options.Where(option => values.Contains(option.Value)).Select(option => option.Text).ToArray();


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 4595, "\"", 4629, 1);
#nullable restore
#line 96 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 4603, String.Join(", ", values), 4603, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" readonly/>\n");
            WriteLiteral("                                        <select class=\"mvc-grid-options\">\n");
#nullable restore
#line 99 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                             foreach (SelectListItem option in column.Filter.Options)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d60b5fc0756da06ba9d92a9aa3bb98ed317a38b20119", async() => {
#nullable restore
#line 101 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                         Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                   WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 102 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </select>\n");
#nullable restore
#line 104 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <select class=\"mvc-grid-value\">\n");
#nullable restore
#line 108 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                             foreach (SelectListItem option in column.Filter.Options)
                                            {
                                                if (column.Filter.First?.Values.Contains(option.Value) == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d60b5fc0756da06ba9d92a9aa3bb98ed317a38b23103", async() => {
#nullable restore
#line 112 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                                      Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                       WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 113 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d60b5fc0756da06ba9d92a9aa3bb98ed317a38b25614", async() => {
#nullable restore
#line 116 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                             Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                       WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 117 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </select>\n");
#nullable restore
#line 120 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 6298, "\"", 6334, 1);
#nullable restore
#line 124 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 6306, column.Filter.First?.Values, 6306, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n");
#nullable restore
#line 125 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 6425, "\"", 6458, 2);
            WriteAttributeValue("", 6433, "mvc-grid-filter", 6433, 15, true);
#nullable restore
#line 126 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 6448, applied, 6448, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\n                            </div>\n                        </th>\n");
#nullable restore
#line 129 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th");
            BeginWriteAttribute("class", " class=\"", 6631, "\"", 6668, 2);
#nullable restore
#line 132 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 6639, column.CssClasses, 6639, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 6659, hidden, 6659, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\n");
#nullable restore
#line 133 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 136 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </thead>\n        <tbody>\n");
#nullable restore
#line 139 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
         foreach (IGridRow<Object> row in rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <");
            WriteLiteral("tr");
#nullable restore
#line 141 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
            Write(row.Attributes);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n");
#nullable restore
#line 142 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                 foreach (IGridColumn column in Model.Columns)
                {
                    String classes = (column.IsHidden ? column.CssClasses + " mvc-grid-hidden" : column.CssClasses).Trim();

                    if (String.IsNullOrEmpty(classes))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 148 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                       Write(column.ValueFor(row));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 149 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("class", " class=\"", 7304, "\"", 7320, 1);
#nullable restore
#line 152 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 7312, classes, 7312, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 152 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                        Write(column.ValueFor(row));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 153 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </");
            WriteLiteral("tr>\n");
#nullable restore
#line 156 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
         if (!Model.Rows.Any() && Model.EmptyText != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"mvc-grid-empty-row\">\n                <td");
            BeginWriteAttribute("colspan", " colspan=\"", 7550, "\"", 7582, 1);
#nullable restore
#line 160 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
WriteAttributeValue("", 7560, Model.Columns.Count(), 7560, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 161 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
               Write(Html.Raw(Model.EmptyText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 164 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n");
#nullable restore
#line 166 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
         if (!String.IsNullOrEmpty(Model.FooterPartialViewName))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tfoot>\n            ");
#nullable restore
#line 169 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
       Write(await Html.PartialAsync(Model.FooterPartialViewName, Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tfoot>\n");
#nullable restore
#line 171 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </");
            WriteLiteral("table>\n");
#nullable restore
#line 173 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
     if (Model.Pager != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
   Write(await Html.PartialAsync(Model.Pager.PartialViewName, Model.Pager));

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "/home/aslani/Desktop/PlineFaxServer/Views/Shared/MvcGrid/_Grid.cshtml"
                                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGrid> Html { get; private set; }
    }
}
#pragma warning restore 1591