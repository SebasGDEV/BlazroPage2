#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5b472fc0f202edafe3d0bdc1d45d9600e3934a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
 
     string DiasdeVacaciones;
     string SalarioMensual;
     DateTime FechaInicio, FechaTerminacion;
     double salarioDiario,  pagoVacaciones, noventaDiasSalario, doceDiasSalario, 
     _salarioMensual, _diasdeVacaciones, threeMonthsSalary, twentyDaysSalary, Aguinaldo;

     
     

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                           

    public void sumar(){

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                
        _salarioMensual = Convert.ToDouble(SalarioMensual);
        _diasdeVacaciones=Convert.ToDouble(DiasdeVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                     
        Console.WriteLine(FechaTerminacion.ToString("MM/dd/yyyy"));

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                                                         
        int currentyear=Convert.ToInt32(FechaTerminacion.ToString("yyyy"));
        System.Console.WriteLine("Año en curso: " + currentyear);
        string FechaAnioEnCursoString=("01/01/"+currentyear);
        DateTime FechaAnioEnCurso=Convert.ToDateTime(FechaAnioEnCursoString);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                      
        int startedyearString=Convert.ToInt32(FechaInicio.ToString("yyyy"));
        System.Console.WriteLine("Año de inicio es: " + startedyearString);
        DateTime startedyear=Convert.ToDateTime("01/01/"+startedyearString);
        System.Console.WriteLine("Año de inicio: "+ startedyear);


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                              
        var DiasAnioEnCurso1=FechaTerminacion-FechaAnioEnCurso;
        int DiasAnioEnCurso=(int)(DiasAnioEnCurso1.TotalDays);
        System.Console.WriteLine("Dias del Año en curso restadas: " + DiasAnioEnCurso);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                       

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
#line 110 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                       
        Console.WriteLine("RESULTADO");
        Console.WriteLine(years + " Años");
        Console.WriteLine(months + " Meses");
        Console.WriteLine(dayss + " Dias");

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                            
        Console.WriteLine(_salarioMensual);
        salarioDiario=(_salarioMensual/30);
        Console.WriteLine("El salario diario es: "+ salarioDiario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                        
        pagoVacaciones=salarioDiario*_diasdeVacaciones;
        Console.WriteLine("Pago de vacaciones: "+ pagoVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                 
        noventaDiasSalario=salarioDiario*90;
        Console.WriteLine("90 dias de salario: "+ noventaDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                 
        doceDiasSalario=salarioDiario*12*years;
        Console.WriteLine("12 dias de salario: "+ doceDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                         
        double salarioAguinaldoDiario=Convert.ToDouble((salarioDiario*15)/365);
        Console.WriteLine("Aguinaldo por dia es: "+ salarioAguinaldoDiario);
        if (FechaAnioEnCurso==startedyear)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                      
            Aguinaldo=Convert.ToDouble((double)(((FechaTerminacion-FechaInicio).TotalDays)+1)*salarioAguinaldoDiario);
            System.Console.WriteLine("Aguinaldo cuando es el mismo año: "+ Aguinaldo);
        }else{
            Aguinaldo=Convert.ToDouble(salarioAguinaldoDiario*DiasAnioEnCurso);
            Console.WriteLine("Aguinaldo es: "+ Aguinaldo);
        }
        
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                           
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
#line 159 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                                
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
#line 169 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                                     



         
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
#line 191 "C:\Users\SGARCORO\Documents\GitHub\BlazroPage2\Pages\Liquidacion.razor"
                  
        private void ModalForInfo(MouseEventArgs e, int infoModal)
        {
           System.Console.WriteLine("ea");
           System.Console.WriteLine(infoModal);

    
    
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
#pragma warning restore 1591
