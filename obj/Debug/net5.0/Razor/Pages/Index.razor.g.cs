#pragma checksum "C:\Users\Bruger\RiderProjects\Client\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0131ec9d7874aacec84ec2d5145346acab3d744e"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\Client\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1><p style=\"font-family:\'Courier New\'\">Danmarks fastfood</p></h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "style", "font-family:\'Courier New\'");
            __builder.OpenComponent<Client.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "Spist hos os før ?");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.AddMarkupContent(6, @"<p style=""color:pink""><h3><p style=""font-family:'Courier New'"">Betaling ved døren, så du er tryg med dine penge</p></h3><br><br>

    <h3><p style=""font-family:'Courier New'"">Aktiv feedback til os i køkkenet så vi ved, hvad i som kunder er glade for</p></h3><br><br>

    <h3><p style=""font-family:'Courier New'"">Massere kærlighed i vores mad</p></h3>
    
    <img src=""boog.gif"" alt=""Italian Trulli""></p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591