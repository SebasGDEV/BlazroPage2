#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65cf9a5f5f6b2f879a7430537784ba6ac380d4d7"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/liquidacion")]
    public partial class Liquidacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "<h1>     Calculadora de Liquidación    </h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width: 20rem;");
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n    <br>  <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_0(__builder, 5, 6, 
#nullable restore
#line 7 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                       true

#line default
#line hidden
#nullable disable
            , 7, "Salario Mensual", 8, 
#nullable restore
#line 7 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
            , 9, "width:-webkit-fill-available;", 10, 
#nullable restore
#line 8 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 7 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                SalarioMensual

#line default
#line hidden
#nullable disable
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SalarioMensual = __value, SalarioMensual)), 13, () => SalarioMensual);
            __builder.AddMarkupContent(14, "\r\n    <br><br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_1(__builder, 15, 16, 
#nullable restore
#line 10 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                         true

#line default
#line hidden
#nullable disable
            , 17, "Dias de Vacaciones", 18, 
#nullable restore
#line 10 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
            , 19, "width:-webkit-fill-available;", 20, 
#nullable restore
#line 11 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 10 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                DiasdeVacaciones

#line default
#line hidden
#nullable disable
            , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DiasdeVacaciones = __value, DiasdeVacaciones)), 23, () => DiasdeVacaciones);
            __builder.AddMarkupContent(24, "\r\n    <br><br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatDatePicker_2(__builder, 25, 26, "Fecha inicio de labores", 27, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                             true

#line default
#line hidden
#nullable disable
            , 28, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
            , 29, "width:-webkit-fill-available;", 30, 
#nullable restore
#line 14 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                             true

#line default
#line hidden
#nullable disable
            , 31, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                 FechaInicio

#line default
#line hidden
#nullable disable
            , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FechaInicio = __value, FechaInicio)), 33, () => FechaInicio);
            __builder.AddMarkupContent(34, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "contenedor");
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(38);
            __builder.AddAttribute(39, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "style", "width: 6rem;");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Limpiar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(44);
            __builder.AddAttribute(45, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "style", "width: 13rem;");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(48, "Calcular");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
 
    public string DiasdeVacaciones="";
    public string SalarioMensual="";
    public DateTime FechaInicio;
    


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Blazor.Pages.Liquidacion
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Dense", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Outlined", __arg2);
        __builder.AddAttribute(__seq3, "style", __arg3);
        __builder.AddAttribute(__seq4, "Required", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Dense", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Outlined", __arg2);
        __builder.AddAttribute(__seq3, "style", __arg3);
        __builder.AddAttribute(__seq4, "Required", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "Outlined", __arg2);
        __builder.AddAttribute(__seq3, "style", __arg3);
        __builder.AddAttribute(__seq4, "EnableWeekNumbers", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591