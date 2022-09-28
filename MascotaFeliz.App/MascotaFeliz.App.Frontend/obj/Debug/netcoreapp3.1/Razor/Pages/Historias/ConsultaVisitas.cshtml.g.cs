#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5ad8fd3ccaa8b76011bdcc6d091e662038317a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Historias.Pages_Historias_ConsultaVisitas), @"mvc.1.0.razor-page", @"/Pages/Historias/ConsultaVisitas.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Historias
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5ad8fd3ccaa8b76011bdcc6d091e662038317a", @"/Pages/Historias/ConsultaVisitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Historias_ConsultaVisitas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Mascotas/ConsultaMascotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Historias/EditarVisita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Veterinarios/ConsultaVeterinarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
  
    int mascotaId = Model.mascota.Id;
    ViewData["Title"] = "Historia Clínica";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""contenido"">

    <div class=""title-container"">
        <h1>Historia Clínica</h1>
    </div> 
    <hr>
    <div class=""profile-box-top"">

        <div class=""info-box"">

            <div class=""trait-box"">
                <span class=""info-title"">ID Historia</span>
                <span class=""info-text"">");
#nullable restore
#line 20 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                   Write(Model.mascota.Historia.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"trait-box\">\r\n                <span class=\"info-title\">Fecha de Creación</span>\r\n                <span class=\"info-text\">");
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                   Write(Model.mascota.Historia.FechaInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"trait-box\">\r\n                <span class=\"info-title\">Mascota</span>\r\n                <span class=\"info-text\">");
#nullable restore
#line 30 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                   Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"trait-box\">\r\n                <span class=\"info-title\">ID Mascota</span>\r\n                <span class=\"info-text\">");
#nullable restore
#line 35 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                   Write(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"trait-box\">\r\n                <span class=\"info-title\">Dueño</span>\r\n                <span class=\"info-text\">");
#nullable restore
#line 40 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                   Write(Model.mascota.Dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                Write(Model.mascota.Dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"trait-box\">\r\n                <span class=\"info-title\">Cédula Dueño</span>\r\n                <span class=\"info-text\">");
#nullable restore
#line 45 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                   Write(Model.mascota.Dueno.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <hr>\r\n        <div class=\"button-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d5ad8fd3ccaa8b76011bdcc6d091e662038317a7613", async() => {
                WriteLiteral("<i class=\"arrow-left\"></i>Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchTerm", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                               WriteLiteral(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchTerm"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchTerm", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchTerm"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d5ad8fd3ccaa8b76011bdcc6d091e662038317a9885", async() => {
                WriteLiteral("Añadir Nueva Visita PyP<i class=\"arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mascotaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           WriteLiteral(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mascotaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        \r\n    <hr>\r\n\r\n    <div class=\"form-container\">\r\n        <div class=\"results-list\">\r\n");
#nullable restore
#line 61 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
             if (Model.mascota.Historia.VisitasPyP != null)
            {
                int x = Model.mascota.Historia.VisitasPyP.Count; 
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                 foreach (var visita in Model.listaVisitas.Reverse())
                //@for(int i = Model.mascota.Historia.VisitasPyP.Count -1; i >= 0; --i)
                {
                    //var visita = Model.mascota.Historia.VisitasPyP[i];
                    var veterinarioEncontrado = Model._repoVeterinario.GetVeterinario(visita.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"data-box\">\r\n                        <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 2610, "\"", 2625, 1);
#nullable restore
#line 70 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
WriteAttributeValue("", 2615, visita.Id, 2615, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 2659, "\"", 2675, 1);
#nullable restore
#line 71 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
WriteAttributeValue("", 2665, visita.Id, 2665, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"profile-button\">\r\n                            <div class=\"button-div\">\r\n                                <p class=\"button-title\">Visita N° ");
#nullable restore
#line 73 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                              Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 73 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                    Write(visita.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"button-subtitle\">ID: ");
#nullable restore
#line 74 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                          Write(visita.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                               
                            </div>
                            <i class=""arrow-down-1""></i>
                        </label>  
                                         
                        <div class=""profile-content"">
                

                            <div class=""profile-box-visita"">
                                
                                <div class=""info-box"">

                                    <h3>Información básica</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Fecha de la visita</span>
                                        <span class=""info-text"">");
#nullable restore
#line 91 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>  

                                    <div class=""trait-box"">
                                        <span class=""info-title"">ID Visita</span>
                                        <span class=""info-text"">");
#nullable restore
#line 96 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div> 
                                </div>


                                <div class=""info-box"">

                                    <h3>Información Mascota</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Mascota</span>
                                        <span class=""info-text"">");
#nullable restore
#line 107 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">ID Mascota</span>
                                        <span class=""info-text"">");
#nullable restore
#line 112 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Color</span>
                                        <span class=""info-text"">");
#nullable restore
#line 117 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Especie</span>
                                        <span class=""info-text"">");
#nullable restore
#line 122 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Raza</span>
                                        <span class=""info-text"">");
#nullable restore
#line 127 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>

                                <div class=""info-box"">

                                    <h3>Información Dueño</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Dueño</span>
                                        <span class=""info-text"">");
#nullable restore
#line 137 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 137 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                                        Write(Model.mascota.Dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Cédula</span>
                                        <span class=""info-text"">");
#nullable restore
#line 142 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Dueno.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">ID Dueño</span>
                                        <span class=""info-text"">");
#nullable restore
#line 147 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Dueno.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Dirección</span>
                                        <span class=""info-text"">");
#nullable restore
#line 152 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Dueno.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Teléfono</span>
                                        <span class=""info-text"">");
#nullable restore
#line 157 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Dueno.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">E-mail</span>
                                        <span class=""info-text"">");
#nullable restore
#line 162 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(Model.mascota.Dueno.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>

                                <div class=""info-box"">
                                    <h3>Información Veterinario</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Veterinario</span>
                                        <span class=""info-text"">");
#nullable restore
#line 171 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(veterinarioEncontrado.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 171 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                                          Write(veterinarioEncontrado.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Cédula</span>
                                        <span class=""info-text"">");
#nullable restore
#line 176 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(veterinarioEncontrado.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">ID Veterinario</span>
                                        <span class=""info-text"">");
#nullable restore
#line 181 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Tarjeta Profesional</span>
                                        <span class=""info-text"">");
#nullable restore
#line 186 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(veterinarioEncontrado.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    
                                </div>


                                <div class=""info-box"">

                                    <h3>Observaciones</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Temperatura</span>
                                        <span class=""info-text"">");
#nullable restore
#line 198 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" °C</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Peso</span>
                                        <span class=""info-text"">");
#nullable restore
#line 203 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Kg</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Frecuencia Respiratoria</span>
                                        <span class=""info-text"">");
#nullable restore
#line 208 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" rpm</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Frecuencia Cardiaca</span>
                                        <span class=""info-text"">");
#nullable restore
#line 213 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ppm</span>
                                    </div>
                                    
                                    <div class=""trait-box"">
                                        <span class=""info-title"">Estado de ánimo</span>
                                        <span class=""info-text"">");
#nullable restore
#line 218 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                           Write(visita.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""text-box-2"">
                                        <span class=""info-title"">Recomendaciones</span>
                                        <span class=""info-paragraph"">");
#nullable restore
#line 223 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                Write(visita.Recomendaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                                \r\n\r\n                                <div class=\"action-box\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d5ad8fd3ccaa8b76011bdcc6d091e662038317a30400", async() => {
                WriteLiteral("Actualizar Datos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-visitaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 229 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                                  WriteLiteral(visita.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["visitaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-visitaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["visitaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 229 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                                                                   WriteLiteral(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mascotaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mascotaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d5ad8fd3ccaa8b76011bdcc6d091e662038317a33496", async() => {
                WriteLiteral("Ver Veterinario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchTerm", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 230 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                                                                                               WriteLiteral(Model.mascota.Veterinario.Cedula);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchTerm"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchTerm", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchTerm"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n                            \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 237 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                    {x = x-1;} 
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 238 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 242 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
             if (Model.mascota.Historia.VisitasPyP.Any() == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"empty-box\">\r\n                    <h2>Lo sentimos.</h2>\r\n                    <h3>Aún no se ha realizado ninguna Visita.</h3>\r\n                </div>\r\n");
#nullable restore
#line 248 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Historias\ConsultaVisitas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ConsultaVisitasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultaVisitasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultaVisitasModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ConsultaVisitasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
