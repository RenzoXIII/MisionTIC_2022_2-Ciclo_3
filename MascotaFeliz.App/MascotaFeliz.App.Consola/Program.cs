using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            //AddHistoria();

            //BuscarDueno(1);
            //BuscarVeterinario(2);
            //BuscarMascota(1);

            //ListarDuenos();
            //ListarVeterinarios();
            //ListarMascotas();

            //AsignarVeterinario();
            //AsignarDueno();
            //AsignarHistoria();

            //BuscarMascota(1);
            //_repoMascota.DeleteMascota(12);
            _repoVisita.DeleteVisitaPyP(4);
        }

        //----Add Methods----

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Cedula = "1414",
                Nombres = "Jose",
                Apellidos = "Perez",
                Direccion = "Av 26 - 35",
                Telefono = "318578475",
                Correo = "joseperez@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Cedula = "1313",
                Nombres = "Pepe",
                Apellidos = "González Florez",
                Direccion = "Av 23 # 57 - 32",
                Telefono = "5555555555",
                TarjetaProfesional = "2190526"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Tommy",
                Color = "Sepia",
                Especie = "Perro",
                Raza = "Cocker Spaniel",
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = DateTime.Now
            };
            _repoHistoria.AddHistoria(historia);
        }

        //----Search Methods----

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Cedula + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Cedula + " " + veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza);
            Console.WriteLine(mascota.Dueno.Nombres);
            Console.WriteLine(mascota.Veterinario.Nombres);
            Console.WriteLine(mascota.Historia.Id);
            if (mascota.Veterinario == null)
            {
                Console.WriteLine("is NULL");
            }
        }

        //----List Multiple Methods----

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario d in veterinarios)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
                Console.WriteLine(d.Nombre);
            }
        }

        //----Asignar a Mascota Methods----

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(2,2);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }
        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(2,4);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }
        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(1,1);
            Console.WriteLine(historia.Id);
        }

        //----Asignar a Historia Methods----

        private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 2, Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 2, Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }
    }
}
