﻿#pragma checksum "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc8a81f8c65f24cb8dab44969e76262cc28e7fe760d5d74e7bcfcff690c4af2c"
// <auto-generated/>
#pragma warning disable 1591
namespace OTBIS.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Data.Production;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Models.ChartArrays;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using OTBIS.Web.Models.ReportObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-column-template")]
    public partial class Columns : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Radzen.Blazor.RadzenText>(0);
            __builder.AddAttribute(1, "TextStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Blazor.TextStyle>(
#nullable restore
#line 9 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor"
                       TextStyle.H3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "TagName", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Blazor.TagName>(
#nullable restore
#line 9 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor"
                                              TagName.H1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", "my-4");
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    Report ");
                __builder2.AddMarkupContent(6, "<strong>Column Template</strong>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenText>(8);
            __builder.AddAttribute(9, "TextStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Blazor.TextStyle>(
#nullable restore
#line 12 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor"
                       TextStyle.Body1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Class", "my-4");
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    The ");
                __builder2.AddMarkupContent(13, "<strong>Template</strong> allows you to customize the way data is displayed.\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenText>(15);
            __builder.AddAttribute(16, "TextStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.Blazor.TextStyle>(
#nullable restore
#line 15 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\Columns.razor"
                       TextStyle.Body2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Class", "my-4");
            __builder.AddAttribute(18, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n    Common uses: Record numbering, displaying an image depending on property value,\r\n    displaying multiple properties in the same column, linking to other pages,\r\n    data formatting and HTML embedding.\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
