#pragma checksum "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e3043c615b68183fd656a579dca644b9ded5e8e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\_Imports.razor"
using BlazorApp.Components;

#line default
#line hidden
#nullable disable
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br b-trxtr01e0f>\r\n<hr b-trxtr01e0f>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 5 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
            klasa

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "b-trxtr01e0f");
            __builder.AddContent(4, "Kalkulator");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "b-trxtr01e0f");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
    operationstring

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br b-trxtr01e0f>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddAttribute(12, "b-trxtr01e0f");
            __builder.AddMarkupContent(13, "<label b-trxtr01e0f>Pierwsza liczba</label>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
                                                          pierwsza

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pierwsza = __value, pierwsza));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(19, "b-trxtr01e0f");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group mt-3");
            __builder.AddAttribute(23, "b-trxtr01e0f");
            __builder.AddMarkupContent(24, "<label b-trxtr01e0f>Druga liczba</label>\r\n    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
                                                          druga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => druga = __value, druga));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(30, "b-trxtr01e0f");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group mt-3");
            __builder.AddAttribute(34, "b-trxtr01e0f");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
                                              Oblicz

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "b-trxtr01e0f");
            __builder.AddContent(39, "Oblicz");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n<br b-trxtr01e0f>\r\n");
            __builder.OpenElement(41, "h1");
            __builder.AddAttribute(42, "b-trxtr01e0f");
            __builder.AddContent(43, "Wynik: ");
            __builder.AddContent(44, 
#nullable restore
#line 20 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
            wynik

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n<hr b-trxtr01e0f>");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\user\OneDrive\Pulpit\BLAZOR\BlazorApp\Components\Calculator.razor"
       

    [Parameter] public string Operation { get; set; }

    int pierwsza = 0;
    int druga = 0;
    double wynik = 0;
    string operationstring;
    string klasa;

    protected override void OnInitialized()
    {
        if (Operation == "+")
        {
            operationstring = "dodawanie";
            klasa = "black";
        }        
        else if (Operation == "-")
        {
            operationstring = "odejmowanie";
            klasa = "red";
        }  
        else if (Operation == "*")
        {
            operationstring = "mnożenie";
            klasa = "blue";
        }         
        else
        {
            operationstring = "dzielenie";
            klasa = "green";
        }
            
    }

    

    async Task Oblicz()
    {
        if (Operation == "+")
            wynik = pierwsza + druga;
        else if (Operation == "-")
            wynik = pierwsza - druga;
        else if (Operation == "*")
            wynik = pierwsza * druga;
        else
        {
            if (druga == 0)
            {
                await JS.InvokeVoidAsync("showAlert", pierwsza);
                return;
            }
            wynik = Convert.ToDouble(pierwsza) / Convert.ToDouble(druga);
            wynik = Math.Round(wynik, 3);
        }
            
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
