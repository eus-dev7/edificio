using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public class PropietarioBRL
    {
        public static object Propietarios()
        {
            DataTable dev = new DataTable();
            
            dev = DAL.Propietario.ListarPropietarios();
            return dev;
        }

        public static void registroPropietario(DAL.Propietario propietario)
        {
            DAL.Propietario.nuevoPrpietario(propietario);
        }

        public static DAL.Propietario buscarPropietario(string p)
        {
            DAL.Propietario dev = new DAL.Propietario();

            dev = DAL.Propietario.buscarPropietario(p);

            return dev;
        }

        public static void ActualizarPropietario(DAL.Propietario propietario)
        {
            DAL.Propietario.actualizarPrpietario(propietario);
        }

        public static void eliminarPropietario(string p)
        {
            DAL.Propietario.eliminarPropietario(p);
        }

        public static object filterPropietarios(string p)
        {
            DataTable dev = new DataTable();

            dev = DAL.Propietario.filtrarPropietarios(p);
            return dev; ;
        }
    }
}
