#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ba8bf21d310d0d758fc785178a876ee63efd4ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_ConsultaVeterinarios), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/ConsultaVeterinarios.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ba8bf21d310d0d758fc785178a876ee63efd4ff", @"/Pages/Veterinarios/ConsultaVeterinarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_ConsultaVeterinarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("list", new global::Microsoft.AspNetCore.Html.HtmlString("veterinarios"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingrese el ID, Nombre o Cédula del veterinario que desea consultar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Imagenes/Placeholder-photo-veterinario.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Veterinarios/EditarVeterinario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Mascotas/ConsultaMascotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
  
    ViewData["Title"] = "Consulta Veterinarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"contenido\">\r\n\r\n    <div class=\"title-container\">\r\n        <h1>Consultar Veterinario</h1>\r\n    </div> \r\n    <hr>\r\n    <div class=\"form-container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba8bf21d310d0d758fc785178a876ee63efd4ff6925", async() => {
                WriteLiteral("\r\n            <div class=\"details-box\">\r\n\r\n                <div class=\"id-box-1\">\r\n                    <span class=\"details\">Buscar Veterinario:</span>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ba8bf21d310d0d758fc785178a876ee63efd4ff7368", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.searchTerm);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                     if (Model.listaVeterinarios != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <datalist id=\"veterinarios\">\r\n");
#nullable restore
#line 23 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                         foreach (var veterinario in Model.listaVeterinarios)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba8bf21d310d0d758fc785178a876ee63efd4ff9984", async() => {
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                               Write(veterinario.Nombres);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                                                    Write(veterinario.Apellidos);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                   WriteLiteral(veterinario.Cedula);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </datalist>\r\n");
#nullable restore
#line 28 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn\" style=\"display: none;\">Search</button>\r\n                    \r\n                </div>\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <hr>\r\n\r\n    <div class=\"form-container\">\r\n        <div class=\"results-list\">\r\n");
#nullable restore
#line 42 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
             if (Model.listaVeterinariosFiltrados != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                 foreach (var veterinario in Model.listaVeterinariosFiltrados)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"data-box\">\r\n                        <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1626, "\"", 1646, 1);
#nullable restore
#line 47 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
WriteAttributeValue("", 1631, veterinario.Id, 1631, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 1680, "\"", 1701, 1);
#nullable restore
#line 48 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
WriteAttributeValue("", 1686, veterinario.Id, 1686, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"profile-button\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ba8bf21d310d0d758fc785178a876ee63efd4ff15825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1839, "Foto", 1839, 4, true);
            AddHtmlAttributeValue(" ", 1843, "de", 1844, 3, true);
            AddHtmlAttributeValue(" ", 1846, "perfil", 1847, 7, true);
            AddHtmlAttributeValue(" ", 1853, "de", 1854, 3, true);
#nullable restore
#line 49 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
AddHtmlAttributeValue(" ", 1856, veterinario.Nombres, 1857, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
AddHtmlAttributeValue(" ", 1877, veterinario.Apellidos, 1878, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"button-div\">\r\n                                <p class=\"button-title\">");
#nullable restore
#line 51 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                   Write(veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                                        Write(veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"button-subtitle\">C.C.: ");
#nullable restore
#line 52 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                            Write(veterinario.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                            <i class=""arrow-down-1""></i>
                        </label>                    
                        <div class=""profile-content"">
                

                            <div class=""profile-box"">
        
                                <div class=""info-box"">
                                    <h3>Información básica</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Nombre</span>
                                        <span class=""info-text"">");
#nullable restore
#line 66 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>  

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Apellidos</span>
                                        <span class=""info-text"">");
#nullable restore
#line 71 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">ID</span>
                                        <span class=""info-text"">");
#nullable restore
#line 76 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div> 

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Cédula</span>
                                        <span class=""info-text"">");
#nullable restore
#line 81 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Tarjeta profesional</span>
                                        <span class=""info-text"">");
#nullable restore
#line 86 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                </div>
                                
                                <div class=""info-box"">

                                    <h3>Información de contacto</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Dirección</span>
                                        <span class=""info-text"">");
#nullable restore
#line 97 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Teléfono</span>
                                        <span class=""info-text"">");
#nullable restore
#line 102 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                           Write(veterinario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n                                <div class=\"action-box\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba8bf21d310d0d758fc785178a876ee63efd4ff23865", async() => {
                WriteLiteral("Actualizar Datos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-veterinarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                                                               WriteLiteral(veterinario.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["veterinarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-veterinarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["veterinarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba8bf21d310d0d758fc785178a876ee63efd4ff26189", async() => {
                WriteLiteral("Ver Mascotas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-veterinarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                                                                                          WriteLiteral(veterinario.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["veterinarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-veterinarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["veterinarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n                                </div>\r\n\r\n                            </div>\r\n                            \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 117 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 121 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
             if (Model.listaVeterinariosFiltrados == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"empty-box\">\r\n                    <h2>Lo sentimos.</h2>\r\n                    <h3>No se encontró ningún resultado que coincida con esta búsqueda.</h3>\r\n                </div>\r\n");
#nullable restore
#line 127 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\ConsultaVeterinarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n        <hr>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ConsultaVeterinariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultaVeterinariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultaVeterinariosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ConsultaVeterinariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
