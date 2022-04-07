using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaIncidencias
{
    public class ClasePrincipal
    {
        public  List<Usuario> Usuarios { get; set; }
        public List<Problema> Problemas { get; set; }

        public void AgregarIncidencia(string observacion, string dependencia, string sucursal)
        {
            Problema newIncidencia = new Problema();

            newIncidencia.cod = DevolverCod();
            newIncidencia.dependencia = dependencia;
            newIncidencia.observacion = observacion;
            newIncidencia.sucursarl = sucursal;
            newIncidencia.FechaHoy = DateTime.Today;
            newIncidencia.estado = false;

            Problemas.Add(newIncidencia);
        }

        public void EliminarIncidencia(int cod)
        {
            foreach (var item in Problemas)
            {
                if (item.cod == cod)
                {
                    Problemas.Remove(item);

                    break;
                }
            }
        }

        public void ModificarIncidencia(int cod, string observacion, string dependencia, string sucursal, bool estado)
        {
            foreach (var item in Problemas)
            {
                if (item.cod == cod)
                {
                    item.dependencia = dependencia;
                    item.observacion = observacion;
                    item.sucursarl = sucursal;
                    item.estado = estado;
                    item.FechaHoy = DateTime.Today;

                    break;
                }
            }
        }

        public void CambiarEstado(int cod, bool estado)
        {
            foreach (var item in Problemas)
            {
                if (item.cod == cod)
                {                 
                    item.estado = estado;

                    break;
                }
            }
        }

        public int DevolverCod()
        {
            int cod = 1;
            if (Problemas != null)
            {
                cod = Problemas.Count() + 1;
            }
            return cod;
        }

        public void GenerarArchivosTXT()
        {
            if (!File.Exists(@"c:\ArchivosTXT\Problemas.txt"))
            {
                string path = @"c:\ArchivosTXT";
                DirectoryInfo di = Directory.CreateDirectory(path);
                using (StreamWriter write = new StreamWriter(@"c:\ArchivosTXT\Problemas.txt", false)) ;
            }
            if (!File.Exists(@"c:\ArchivosTXT\Usuario.txt"))
            {
                string path = @"c:\ArchivosTXT";
                DirectoryInfo di = Directory.CreateDirectory(path);
                using (StreamWriter write = new StreamWriter(@"c:\ArchivosTXT\Usuario.txt", false)) ;
            }
        }

        public void LeerArchivosTXT()
        {
            List<Usuario> ListaUsuario = new List<Usuario>();

            using (StreamReader reader = new StreamReader(@"c:\ArchivosTXT\Usuario.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaUsuario = JsonConvert.DeserializeObject<List<Usuario>>(contenido);

                if (ListaUsuario == null)
                {
                    ListaUsuario = new List<Usuario>();
                }

            }

            Usuarios = ListaUsuario;

            List<Problema> ListaIncidencias = new List<Problema>();

            using (StreamReader reader = new StreamReader(@"c:\ArchivosTXT\Problemas.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaIncidencias = JsonConvert.DeserializeObject<List<Problema>>(contenido);

                if (ListaIncidencias == null)
                {
                    ListaIncidencias = new List<Problema>();
                }

            }

            Problemas = ListaIncidencias;

        }

        public void GuardarIncidencias()
        {
            List<Problema> listIncidencias = Problemas;

            using (StreamWriter write = new StreamWriter(@"c:\ArchivosTXT\Problemas.txt", false))
            {
                string jsonguardarIncidencias = JsonConvert.SerializeObject(listIncidencias);
                write.WriteLine(jsonguardarIncidencias);
            }

        }
    }
}
