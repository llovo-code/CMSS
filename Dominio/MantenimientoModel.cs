using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MantenimientoModel
    {
        MantenimientoDaoa Mdao = new MantenimientoDaoa();

        public DataTable GetMantenimientos(int idEquipo,int idMante)
        {
            return Mdao.GetMantenimientos(idEquipo, idMante);
        }

    }
}
