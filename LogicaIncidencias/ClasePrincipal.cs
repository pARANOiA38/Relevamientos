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

        public void AgregarIncidencia(string observacion, string dependencia, string sucursal, string responsable)
        {
            Problema newIncidencia = new Problema();

            newIncidencia.cod = DevolverCod();
            newIncidencia.dependencia = dependencia;
            newIncidencia.observacion = observacion;
            newIncidencia.sucursal = sucursal;
            newIncidencia.FechaHoy = DateTime.Now.ToString("dd/MM/yyyy");
            newIncidencia.estado = "PENDIENTE";
            newIncidencia.responsable = responsable;

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

        public List<Problema> ObtenerProblemas()
        {
            return Problemas;
        }

        public void ModificarIncidencia(int cod, string observacion, string dependencia, string sucursal, string estado, string responsable)
        {
            foreach (var item in Problemas)
            {
                if (item.cod == cod)
                {
                    item.dependencia = dependencia;
                    item.observacion = observacion;
                    item.sucursal = sucursal;
                    item.estado = estado;                   
                    item.responsable = responsable;

                    break;
                }
            }
        }

        public void CambiarEstado(int cod, string estado)
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
            if (Problemas != null | Problemas.Count == 0)
            {
                cod = Problemas.Count() + 1;
            }
            return cod;
        }

        public bool ValidarUsuario(string user, string pass)
        {
            bool aceptacion = false;

            foreach (var item in Usuarios)
            {
                if (item.user == user && item.pass == pass)
                {
                    aceptacion = true;
                }
            }
            return aceptacion;
        }      

        public void GenerarArchivosTXT()
        {
            if (!File.Exists(@"G:\Mi unidad\BaseDeDatosIncidencia\Problemas.txt"))
            {
                string path = @"G:\Mi unidad\BaseDeDatosIncidencia";
                DirectoryInfo di = Directory.CreateDirectory(path);
                using (StreamWriter write = new StreamWriter(@"G:\Mi unidad\BaseDeDatosIncidencia\Problemas.txt", false));
            }
            if (!File.Exists(@"G:\Mi unidad\BaseDeDatosIncidencia\Usuarios.txt"))
            {
                string path = @"G:\Mi unidad\BaseDeDatosIncidencia";
                DirectoryInfo di = Directory.CreateDirectory(path);
                using (StreamWriter write = new StreamWriter(@"G:\Mi unidad\BaseDeDatosIncidencia\Usuarios.txt", false));
            }
        }

        public void LeerArchivosTXT()
        {
            List<Usuario> ListaUsuario = new List<Usuario>();

            using (StreamReader reader = new StreamReader(@"G:\Mi unidad\BaseDeDatosIncidencia\Usuarios.txt"))
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

            using (StreamReader reader = new StreamReader(@"G:\Mi unidad\BaseDeDatosIncidencia\Problemas.txt"))
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

            using (StreamWriter write = new StreamWriter(@"G:\Mi unidad\BaseDeDatosIncidencia\Problemas.txt", false))
            {
                string jsonguardarIncidencias = JsonConvert.SerializeObject(listIncidencias);
                write.WriteLine(jsonguardarIncidencias);
            }

        }

        public void GuardarUsuarios()
        {
            List<Usuario> listUsuarios = Usuarios;

            using (StreamWriter write = new StreamWriter(@"G:\Mi unidad\BaseDeDatosIncidencia\Usuarios.txt", false))
            {
                string jsonguardarUsuarios = JsonConvert.SerializeObject(listUsuarios);
                write.WriteLine(jsonguardarUsuarios);
            }

        }
    }
}
