#pragma checksum "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7b3fe1d37a4d87f2e305a3f40ee77d4dc9ba30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BorrowedBooks_Index), @"mvc.1.0.view", @"/Views/BorrowedBooks/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7b3fe1d37a4d87f2e305a3f40ee77d4dc9ba30", @"/Views/BorrowedBooks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ab89e7e966b2ee3c0dff6288112219c0ead2e2", @"/Views/_ViewImports.cshtml")]
    public class Views_BorrowedBooks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStore.DAL.Entities.BorrowerBook>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Members", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BorrowedBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
  
    ViewData["Title"] = "Borrowed Books";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7b3fe1d37a4d87f2e305a3f40ee77d4dc9ba304946", async() => {
                WriteLiteral("Back To Members");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<br />
<br />

<table class=""table table-striped table-hover text-center"">

    <thead>
        <tr>
            <th class=""text-center"">Member Code</th>
            <th class=""text-center"">Member Name</th>
            <th class=""text-center"">Book Code</th>
            <th class=""text-center"">Book Name</th>
            <th class=""text-center"">Borrowed At</th>
            <th class=""text-center"">Active</th>

            <th class=""text-center"">Operations</th>

        </tr>
    </thead>
    <tbody>



");
#nullable restore
#line 36 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
               Write(item.Borrower.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
               Write(item.Borrower.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
               Write(item.Book.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
               Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
               Write(item.BorrowAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
                 if (item.Returned == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>No</td>\r\n                    <td>   <input class=\"btn btn-success\" value=\"Returned\" style=\"width:120px\" disabled /></td>\r\n");
#nullable restore
#line 49 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"


                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Yes</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7b3fe1d37a4d87f2e305a3f40ee77d4dc9ba309352", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"BookId\"");
                BeginWriteAttribute("value", " value=\"", 1535, "\"", 1555, 1);
#nullable restore
#line 57 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
WriteAttributeValue("", 1543, item.BookId, 1543, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"BorrowerId\"");
                BeginWriteAttribute("value", " value=\"", 1627, "\"", 1651, 1);
#nullable restore
#line 58 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
WriteAttributeValue("", 1635, item.BorrowerId, 1635, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Return\" style=\"width:120px\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 62 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Mohamed Sayed\source\repos\Book Store\BookStore\Views\BorrowedBooks\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStore.DAL.Entities.BorrowerBook>> Html { get; private set; }
    }
}
#pragma warning restore 1591
