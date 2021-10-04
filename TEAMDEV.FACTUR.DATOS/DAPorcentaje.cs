using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEAMDEV.FACTUR.ENTITY.Parametros;
using TEAMDEV.FACTUR.ENTITY.Response;
namespace TEAMDEV.FACTUR.DATOS
{
    public class DAPorcentaje
    {
        public List<ResponsePorcentaje> listarPorcentaje(RegistroEmpresaEN paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponsePorcentaje>();
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ListarPorcentaje", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var result = new ResponsePorcentaje();
                            result.idPorcentaje = Convert.ToInt32(rdr["idPorcentaje"]);
                            result.Porcentaje = Convert.ToString(rdr["Porcentaje"]);
                            lista.Add(result);
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
