#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4242f47f695a8ecb55a4fc8906d03933c1c7b2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Duenos.Pages_Duenos_ConsultaDuenos), @"mvc.1.0.razor-page", @"/Pages/Duenos/ConsultaDuenos.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Duenos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4242f47f695a8ecb55a4fc8906d03933c1c7b2f8", @"/Pages/Duenos/ConsultaDuenos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Duenos_ConsultaDuenos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("list", new global::Microsoft.AspNetCore.Html.HtmlString("duenos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingrese el Nombre o la C??dula del due??o que desea consultar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Duenos/EditarDueno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Imagenes/P-Persona.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Mascotas/ConsultaMascotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
  
    ViewData["Title"] = "Consulta Due??os";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"contenido\">\r\n\r\n    <div class=\"title-container\">\r\n        <h1>Consultar Due??o</h1>\r\n    </div> \r\n    <hr>\r\n    <div class=\"form-container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f87428", async() => {
                WriteLiteral("\r\n            <div class=\"details-box\">\r\n\r\n                <div class=\"id-box-1\">\r\n                    <span class=\"details\">Buscar Due??o:</span>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f87865", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 19 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
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
#line 20 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                     if (Model.listaDuenos != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <datalist id=\"duenos\">\r\n");
#nullable restore
#line 23 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                         foreach (var dueno in Model.listaDuenos)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f810421", async() => {
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                         Write(dueno.Nombres);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                                        Write(dueno.Apellidos);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                   WriteLiteral(dueno.Cedula);

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
#line 26 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </datalist>\r\n");
#nullable restore
#line 28 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n\r\n    <hr>\r\n        <div class=\"button-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f814587", async() => {
                WriteLiteral("<i class=\"arrow-left\"></i>Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f815866", async() => {
                WriteLiteral("A??adir Nuevo Due??o<i class=\"arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        \r\n    <hr>\r\n\r\n    <div class=\"form-container\">\r\n        <div class=\"results-list\">\r\n");
#nullable restore
#line 48 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
             if (Model.listaDuenosFiltrados != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                 foreach (var dueno in Model.listaDuenosFiltrados)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"data-box\">\r\n                        <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1797, "\"", 1811, 1);
#nullable restore
#line 53 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
WriteAttributeValue("", 1802, dueno.Id, 1802, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 1845, "\"", 1860, 1);
#nullable restore
#line 54 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
WriteAttributeValue("", 1851, dueno.Id, 1851, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"profile-button\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f818736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1978, "Foto", 1978, 4, true);
            AddHtmlAttributeValue(" ", 1982, "de", 1983, 3, true);
            AddHtmlAttributeValue(" ", 1985, "perfil", 1986, 7, true);
            AddHtmlAttributeValue(" ", 1992, "de", 1993, 3, true);
#nullable restore
#line 55 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
AddHtmlAttributeValue(" ", 1995, dueno.Nombres, 1996, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
AddHtmlAttributeValue(" ", 2010, dueno.Apellidos, 2011, 16, false);

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
#line 57 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                   Write(dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                                  Write(dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"button-subtitle\">C.C.: ");
#nullable restore
#line 58 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                            Write(dueno.Cedula);

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
                                    <h3>Informaci??n b??sica</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Nombre</span>
                                        <span class=""info-text"">");
#nullable restore
#line 72 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>  

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Apellidos</span>
                                        <span class=""info-text"">");
#nullable restore
#line 77 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">ID</span>
                                        <span class=""info-text"">");
#nullable restore
#line 82 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div> 

                                    <div class=""trait-box"">
                                        <span class=""info-title"">C??dula</span>
                                        <span class=""info-text"">");
#nullable restore
#line 87 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                </div>
                                
                                <div class=""info-box"">

                                    <h3>Informaci??n de contacto</h3>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Direcci??n</span>
                                        <span class=""info-text"">");
#nullable restore
#line 98 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">Tel??fono</span>
                                        <span class=""info-text"">");
#nullable restore
#line 103 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>

                                    <div class=""trait-box"">
                                        <span class=""info-title"">E-mail</span>
                                        <span class=""info-text"">");
#nullable restore
#line 108 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                           Write(dueno.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"action-box\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f826526", async() => {
                WriteLiteral("Actualizar Datos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-duenoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                                             WriteLiteral(dueno.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["duenoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-duenoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["duenoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4242f47f695a8ecb55a4fc8906d03933c1c7b2f828790", async() => {
                WriteLiteral("Ver Mascotas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchDueno", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                                                        WriteLiteral(dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 114 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                                                                                                       WriteLiteral(dueno.Apellidos);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchDueno"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchDueno", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchDueno"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n                                </div>\r\n\r\n                            </div>\r\n                            \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 122 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 126 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
             if (Model.listaDuenosFiltrados.Any() == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"empty-box\">\r\n                    <h2>Lo sentimos.</h2>\r\n                    <h3>No se encontr?? ning??n resultado que coincida con esta b??squeda.</h3>\r\n                </div>\r\n");
#nullable restore
#line 132 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Duenos\ConsultaDuenos.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ConsultaDuenosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultaDuenosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ConsultaDuenosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ConsultaDuenosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
