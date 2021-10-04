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
    public class DATipoImpuesto
    {
        public List<ResponseTImpuesto> listarTImpuesto(RegistroEmpresaEN paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<ResponseTImpuesto>();
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ListarTipoImpuesto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var result = new ResponseTImpuesto();
                            result.idTipoImpuesto = Convert.ToInt32(rdr["idTipoImpuesto"]);
                            result.TipoImpuesto = Convert.ToString(rdr["TipoImpuesto"]);
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
