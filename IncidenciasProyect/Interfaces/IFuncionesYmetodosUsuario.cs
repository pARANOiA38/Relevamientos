using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaIncidencias;

namespace IncidenciasProyect
{
    interface IFuncionesYmetodosUsuario
    {
        void AgregarIncidencia(string observacion, string dependencia, string sucursal, string responsable);
        void EliminarIncidencia(int cod);
        void ModificarIncidencia(int cod, string observacion, string dependencia, string sucursal, string estado, string responsable);
        void CambiarEstado(int cod, string estado);
        int DevolverCod();
        bool ValidarUsuario(string user, string pass);
        void LeerArchivosTXT();
        void GuardarIncidencias();
        List<Problema> ObtenerProblemas();

    }
}
