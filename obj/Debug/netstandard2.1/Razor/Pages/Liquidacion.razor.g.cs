#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf1429b767823cbb9efe174cb8226b4d158ab9f5"
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
#line 1 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\_Imports.razor"
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
            __builder.AddMarkupContent(1, "<h3>     Calculadora de Liquidación    </h3>\r\n<br>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "box-liquidacion");
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "contenedorcalculadora");
            __builder.AddMarkupContent(7, "\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_0(__builder, 8, 9, "txtSalarioMensual", 10, 
#nullable restore
#line 9 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                              true

#line default
#line hidden
#nullable disable
            , 11, "Salario Mensual", 12, 
#nullable restore
#line 9 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 13, "width:-webkit-fill-available;", 14, 
#nullable restore
#line 10 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 9 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                       SalarioMensual

#line default
#line hidden
#nullable disable
            , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SalarioMensual = __value, SalarioMensual)), 17, () => SalarioMensual);
            __builder.AddMarkupContent(18, "\r\n    <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_1(__builder, 19, 20, "txtDiasdeVacaciones", 21, 
#nullable restore
#line 12 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 22, "Dias de Vacaciones", 23, 
#nullable restore
#line 12 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
            , 24, "width:-webkit-fill-available;", 25, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 12 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                         DiasdeVacaciones

#line default
#line hidden
#nullable disable
            , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DiasdeVacaciones = __value, DiasdeVacaciones)), 28, () => DiasdeVacaciones);
            __builder.AddMarkupContent(29, "\r\n    <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatDatePicker_2(__builder, 30, 31, "FechaIniciodeLabores", 32, "Fecha inicio de labores", 33, 
#nullable restore
#line 15 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 15 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                                  true

#line default
#line hidden
#nullable disable
            , 35, "width:-webkit-fill-available;", 36, 
#nullable restore
#line 16 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                             true

#line default
#line hidden
#nullable disable
            , 37, 
#nullable restore
#line 15 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                           FechaInicio

#line default
#line hidden
#nullable disable
            , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FechaInicio = __value, FechaInicio)), 39, () => FechaInicio);
            __builder.AddMarkupContent(40, "\r\n    <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatDatePicker_3(__builder, 41, 42, "FechaFindeLabores", 43, "Fecha fin de labores", 44, 
#nullable restore
#line 18 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            , 45, 
#nullable restore
#line 18 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
            , 46, "width:-webkit-fill-available;", 47, 
#nullable restore
#line 19 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                             true

#line default
#line hidden
#nullable disable
            , 48, 
#nullable restore
#line 18 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                     FechaTerminacion

#line default
#line hidden
#nullable disable
            , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FechaTerminacion = __value, FechaTerminacion)), 50, () => FechaTerminacion);
            __builder.AddMarkupContent(51, "\r\n    <br>\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "contenedor");
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(55);
            __builder.AddAttribute(56, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "style", "width: 6rem;");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                             LimpiarFormulario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(60, "Limpiar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(62);
            __builder.AddAttribute(63, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "style", "width: 13rem;");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                              sumar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(67, "Calcular");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    \r\n \r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "contenedorcalculadora");
            __builder.AddMarkupContent(73, "\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_4(__builder, 74, 75, "lblSalarioDiario", 76, 
#nullable restore
#line 31 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 77, "SalarioDiario", 78, 
#nullable restore
#line 31 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                  false

#line default
#line hidden
#nullable disable
            , 79, "width:-webkit-fill-available;", 80, 
#nullable restore
#line 31 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                      salarioDiario

#line default
#line hidden
#nullable disable
            , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => salarioDiario = __value, salarioDiario)), 82, () => salarioDiario);
            __builder.AddMarkupContent(83, "\r\n    <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_5(__builder, 84, 85, "lblAguinaldoProporcional", 86, 
#nullable restore
#line 34 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            , 87, "Aguinaldo", 88, 
#nullable restore
#line 34 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                   false

#line default
#line hidden
#nullable disable
            , 89, "width:-webkit-fill-available;", 90, 
#nullable restore
#line 34 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                              Aguinaldo

#line default
#line hidden
#nullable disable
            , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Aguinaldo = __value, Aguinaldo)), 92, () => Aguinaldo);
            __builder.AddMarkupContent(93, "\r\n    <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_6(__builder, 94, 95, "lblTHreeMonthsSalary", 96, 
#nullable restore
#line 37 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
            , 97, "3 Meses de Salario", 98, 
#nullable restore
#line 37 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                               false

#line default
#line hidden
#nullable disable
            , 99, "width:-webkit-fill-available;", 100, "info", 101, "async () => await ModalForInfo(1)", 102, 
#nullable restore
#line 37 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                          threeMonthsSalary

#line default
#line hidden
#nullable disable
            , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => threeMonthsSalary = __value, threeMonthsSalary)), 104, () => threeMonthsSalary);
            __builder.AddMarkupContent(105, "\r\n    <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_7(__builder, 106, 107, "lblTwentyDaysSalary", 108, 
#nullable restore
#line 40 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 109, "3 Meses de Salario", 110, 
#nullable restore
#line 40 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                                                             false

#line default
#line hidden
#nullable disable
            , 111, "width:-webkit-fill-available;", 112, 
#nullable restore
#line 40 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                         twentyDaysSalary

#line default
#line hidden
#nullable disable
            , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => twentyDaysSalary = __value, twentyDaysSalary)), 114, () => twentyDaysSalary);
            __builder.AddMarkupContent(115, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n    \r\n    \r\n    \r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
 
     string DiasdeVacaciones;
     string SalarioMensual;
     DateTime FechaInicio, FechaTerminacion;
     double salarioDiario,  pagoVacaciones, noventaDiasSalario, doceDiasSalario, 
     _salarioMensual, _diasdeVacaciones, threeMonthsSalary, twentyDaysSalary;

     int Aguinaldo=0;
     

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                           

    public void sumar(){

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                
        _salarioMensual = Convert.ToDouble(SalarioMensual);
        _diasdeVacaciones=Convert.ToDouble(DiasdeVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                     
        Console.WriteLine(FechaTerminacion.ToString("MM/dd/yyyy"));

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                         
        int currentyear=Convert.ToInt32(FechaTerminacion.ToString("yyyy"));
        System.Console.WriteLine("Año en curso: " + currentyear);
        string FechaAnioEnCursoString=("01/01/"+currentyear);
        DateTime FechaAnioEnCurso=Convert.ToDateTime(FechaAnioEnCursoString);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                      
        int startedyearString=Convert.ToInt32(FechaInicio.ToString("yyyy"));
        System.Console.WriteLine("Año de inicio es: " + startedyearString);
        DateTime startedyear=Convert.ToDateTime("01/01/"+startedyearString);
        System.Console.WriteLine("Año de inicio: "+ startedyear);


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                              
        var DiasAnioEnCurso1=FechaTerminacion-FechaAnioEnCurso;
        int DiasAnioEnCurso=(int)(DiasAnioEnCurso1.TotalDays);
        System.Console.WriteLine("Dias del Año en curso restadas: " + DiasAnioEnCurso);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                       

        Console.WriteLine("Proceamiento de las fechas");
        var yearsOld = FechaTerminacion - FechaInicio;
        Console.WriteLine("Dias del test: "+ yearsOld);
        int years = (int)(yearsOld.TotalDays / 365.25);
        int months = (int)(((yearsOld.TotalDays / 365.25) - years) * 12);
        int dayss= (int)(( ( ( ( yearsOld.TotalDays / 365.25) - years) * 12)-months)*30.5);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                       
        Console.WriteLine("RESULTADO");
        Console.WriteLine(years + " Años");
        Console.WriteLine(months + " Meses");
        Console.WriteLine(dayss + " Dias");

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                            
        Console.WriteLine(_salarioMensual);
        salarioDiario=(_salarioMensual/30);
        Console.WriteLine("El salario diario es: "+ salarioDiario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                        
        pagoVacaciones=salarioDiario*_diasdeVacaciones;
        Console.WriteLine("Pago de vacaciones: "+ pagoVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                 
        noventaDiasSalario=salarioDiario*90;
        Console.WriteLine("90 dias de salario: "+ noventaDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                 
        doceDiasSalario=salarioDiario*12*years;
        Console.WriteLine("12 dias de salario: "+ doceDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                         
        int salarioAguinaldoDiario=Convert.ToInt32((salarioDiario*15)/365.25);
        if (FechaAnioEnCurso==startedyear)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                      
            Aguinaldo=Convert.ToInt32((int)(((FechaTerminacion-FechaInicio).TotalDays)+1)*salarioAguinaldoDiario);
            System.Console.WriteLine("Aguinaldo cuando es el mismo año: "+ Aguinaldo);
        }else{
            Aguinaldo=Convert.ToInt32(salarioAguinaldoDiario*DiasAnioEnCurso);
            Console.WriteLine("Aguinaldo es: "+ Aguinaldo);
        }
        
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                           
        if(dayss>30)
        {
            threeMonthsSalary=salarioDiario*90;
            System.Console.WriteLine("Salario de 3 meses: " + threeMonthsSalary);
        }else
        {
            System.Console.WriteLine("La relación Patron-Empleado fue menor a 30 dias");
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                
        if(dayss>30 && years>=1)
        {
            twentyDaysSalary=salarioDiario*20*years;
            System.Console.WriteLine("20 dias por año: " + twentyDaysSalary);
        }else{
            System.Console.WriteLine("La relación Patron-Empleado fue menor a 30 dias");
        }


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                     



         
    }




/*Utilidades*/

        private void LimpiarFormulario()
        {
        DiasdeVacaciones=string.Empty;
        SalarioMensual=string.Empty;
        FechaInicio=DateTime.Now;
        }
    

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                  
        public void ModalForInfo(int infoModal)
        {
            System.Console.WriteLine("Estoy en info Modal: " + infoModal);
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await js.InvokeVoidAsync("focusById", "txtSalarioMensual");
            }
        }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.Blazor.Pages.Liquidacion
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Required", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Required", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "EnableWeekNumbers", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "EnableWeekNumbers", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, System.Object __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Icon", __arg5);
        __builder.AddAttribute(__seq6, "@IconOnClick", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
