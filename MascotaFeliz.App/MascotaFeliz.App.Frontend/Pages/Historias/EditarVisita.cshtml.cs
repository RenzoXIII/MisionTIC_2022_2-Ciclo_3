using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarVisitaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota; 
        private readonly IRepositorioVisitaPyP _repoVisita; 
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;

        [BindProperty]
        public VisitaPyP visita {get;set;}
        [BindProperty]
        public Mascota mascota {get;set;}

        public VisitaPyP visitaCreada {get;set;}

        public IEnumerable<Veterinario> listaVeterinarios {get;set;}
        public IEnumerable<Veterinario> listaVeterinariosInOrder {get;set;}



        public EditarVisitaModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }

         public IActionResult OnGet(int? visitaId, int? mascotaId)
        {
            
            if (mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);
                //Console.WriteLine(mascota.Id);

            }
            else
            {
                return RedirectToPage("./NotFound");
            }

            if (visitaId.HasValue)
            {
                visita = _repoVisita.GetVisitaPyP(visitaId.Value);

            }
            else
            {
                visita = new VisitaPyP();
            }

            if (visita == null || mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            listaVeterinariosInOrder = listaVeterinarios.OrderBy(x=>x.Nombres).ThenBy(x=>x.Apellidos);
            return Page();
            }
        }
        

        public IActionResult OnPost()
        {
    
            if (!ModelState.IsValid)
            {
                return Page();
            }
            mascota = _repoMascota.GetMascota(mascota.Id);
            //Console.WriteLine(mascota);
            //Console.WriteLine(mascota.Id + "/" +mascota.Nombre + "/" + mascota.Color + "/" + mascota.Especie + "/" + mascota.Raza);
            visita.FechaVisita = DateTime.Now;

            if(visita.Recomendaciones == null){
                visita.Recomendaciones = "Ninguna.";
            }

            if (visita.Id > 0)
            {
                _repoVisita.UpdateVisitaPyP(visita);
            }
            else
            {     
                if (mascota.Historia != null)
                {
                    Console.WriteLine(mascota.Historia.Id);
                    visitaCreada = _repoVisita.AddVisitaPyP(visita);

                    if (mascota.Historia.VisitasPyP != null)
                    {
                        mascota.Historia.VisitasPyP.Add(visitaCreada);
                    }
                    else
                    {
                        mascota.Historia.VisitasPyP = new List<VisitaPyP>{
                            visitaCreada
                        };
                    }
                    _repoHistoria.UpdateHistoria(mascota.Historia);
                }
            }

            return RedirectToPage("/Historias/ConsultaVisitas", new { mascotaId = mascota.Id });
            //return Page();
            
        }
    }
}
