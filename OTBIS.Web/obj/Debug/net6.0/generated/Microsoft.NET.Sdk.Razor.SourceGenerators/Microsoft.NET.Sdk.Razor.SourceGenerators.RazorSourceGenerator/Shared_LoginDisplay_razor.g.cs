﻿#pragma checksum "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\LoginDisplay.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b5075cf2f95730b95a4f61917b37a597b7e7635cd9ecc51d16397b08db4b695f"
// <auto-generated/>
#pragma warning disable 1591
namespace OTBIS.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 8 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\_Imports.razor"
using Microsoft.JSInterop;

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
    public partial class LoginDisplay : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "b-32g1d44yrw");
                __builder2.AddMarkupContent(4, "<div class=\"container-fluid logo px-3\" b-32g1d44yrw>\r\n                \r\n>\r\n</div>\r\n            ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "b-32g1d44yrw");
                __builder2.OpenElement(7, "a");
                __builder2.AddAttribute(8, "href", "Identity/Account/Manage");
                __builder2.AddAttribute(9, "b-32g1d44yrw");
                __builder2.AddContent(10, "Hello, ");
#nullable restore
#line (11,59)-(11,86) 26 "C:\Users\Rachael\OneDrive\MSc Software Development\OTBIS\OTBIS.Web\Shared\LoginDisplay.razor"
__builder2.AddContent(11, context.User.Identity?.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "!");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<div b-32g1d44yrw><form method=\"post\" action=\"Identity/Account/LogOut\" b-32g1d44yrw><button type=\"submit\" class=\"nav-link btn btn-link\" b-32g1d44yrw>Log out</button></form></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(15, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "<div class=\"container-fluid logo px-3\" b-32g1d44yrw></div>\r\n        ");
                __builder2.AddMarkupContent(17, "<a class=\"login\" href=\"Identity/Account/Register\" b-32g1d44yrw>Register</a>\r\n        ");
                __builder2.AddMarkupContent(18, "<a class=\"login\" href=\"Identity/Account/Login\" b-32g1d44yrw>Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
