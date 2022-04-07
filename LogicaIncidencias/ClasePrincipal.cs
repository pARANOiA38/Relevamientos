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
        public  List<Incidencia> Incidencias { get; set; }
        public  List<Usuario> Usuarios { get; set; }

        public void AgregarIncidencia(string observacion, string dependencia, string sucursal)
        {         
            Incidencia newIncidencia = new Incidencia();

            newIncidencia.cod = DevolverCod();
            newIncidencia.dependencia = dependencia;
            newIncidencia.observacion = observacion;
            newIncidencia.sucursarl = sucursal;
            newIncidencia.FechaHoy = DateTime.Today;
            newIncidencia.estado = false;

            Incidencias.Add(newIncidencia);
        }

        public void EliminarIncidencia(int cod)
        {
            foreach (var item in Incidencias)
            {
                if (item.cod == cod)
                {
                    Incidencias.Remove(item);

                    break;
                }
            }
        }

        public void ModificarIncidencia(int cod, string observacion, string dependencia, string sucursal, bool estado)
        {
            foreach (var item in Incidencias)
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
            foreach (var item in Incidencias)
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
            if (Incidencias != null)
            {
                cod = Incidencias.Count() + 1;
            }
            return cod;
        }

        public void GenerarArchivosTXT()
        {
            if (!File.Exists(@"c:\ArchivosTXT\Incidencias.txt"))
            {
                string path = @"c:\ArchivosTXT";
                DirectoryInfo di = Directory.CreateDirectory(path);
                using (StreamWriter write = new StreamWriter(@"c:\ArchivosTXT\Incidencias.txt", false)) ;
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

            List<Incidencia> ListaIncidencias = new List<Incidencia>();

            using (StreamReader reader = new StreamReader(@"c:\ArchivosTXT\Administradores.txt"))
            {
                string contenido = reader.ReadToEnd();
                ListaIncidencias = JsonConvert.DeserializeObject<List<Incidencia>>(contenido);

                if (ListaIncidencias == null)
                {
                    ListaIncidencias = new List<Incidencia>();
                }

            }

            Incidencias = ListaIncidencias;

        }

        public void GuardarIncidencias()
        {
            List<Incidencia> listIncidencias = Incidencias;

            using (StreamWriter write = new StreamWriter(@"c:\ArchivosTXT\Incidencia.txt", false))
            {
                string jsonguardarIncidencias = JsonConvert.SerializeObject(listIncidencias);
                write.WriteLine(jsonguardarIncidencias);
            }

        }
    }
}
