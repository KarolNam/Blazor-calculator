// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\Pages\Lista.razor"
using BlazorApp.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista")]
    public partial class Lista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\studia\2 semestr\wybrane środowiska programowania\Blazor-calculator\BlazorApp\Pages\Lista.razor"
       
    private List<User> users;
    private User nowy = new User();
    private string fn;
    private string ln;
    private string FirstName {get; set;}
    private string LastName {get; set;}

    protected override void OnInitialized()
    {
        users = new List<User>
            {
                new User(){Id = 1, FirstName = "Adam", LastName = "Mickiewicz"}
            };
    }
    void AddUser()
    {
        var nowy = new User();
        {
            Id = users.Max(u => u.Id) + 1;
            FirstName = fn;
            LastName = ln;
        }
        users.Add(nowy);
        nowy.FirstName = nowy. LastName = string.Empty;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
