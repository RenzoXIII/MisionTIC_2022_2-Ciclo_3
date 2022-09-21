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
    public class EditarMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota; 
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;

        [BindProperty]
        public Mascota mascota {get;set;}


        public IEnumerable<Mascota> listaMascotas {get;set;}
        public IEnumerable<Dueno> listaDuenos {get;set;}
        public IEnumerable<Veterinario> listaVeterinarios {get;set;}



        public EditarMascotaModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }

         public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);

            }
            else
            {
                mascota = new Mascota();
            }
            if (mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else{
                listaMascotas = _repoMascota.GetAllMascotas();
                listaDuenos = _repoDueno.GetAllDuenos();
                listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
                return Page();
            }
        }
        
        public IActionResult OnPost()
        {
    
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int idDueno = mascota.Dueno.Id;
            int idVeterinario = mascota.Veterinario.Id;

            if (mascota.Id > 0)
            {
                mascota.Dueno = _repoDueno.GetDueno(mascota.Dueno.Id);
                mascota.Veterinario = _repoVeterinario.GetVeterinario(mascota.Veterinario.Id);
                
                _repoMascota.UpdateMascota(mascota);
            }
            else
            {
                mascota.Dueno = null;
                mascota.Veterinario = null;
                
                mascota = _repoMascota.AddMascota(mascota);

                mascota.Dueno = _repoDueno.GetDueno(idDueno);
                mascota.Veterinario = _repoVeterinario.GetVeterinario(idVeterinario);

                Historia historia = new Historia {FechaInicial = DateTime.Now};
                Historia historia2 = _repoHistoria.AddHistoria(historia);
                mascota.Historia = _repoHistoria.GetHistoria(historia2.Id);

                _repoMascota.UpdateMascota(mascota);
            }

            return RedirectToPage("/Mascotas/ConsultaMascotas");
            //return Page();
        }
    }
}
