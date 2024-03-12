using CRUDCORE.Models;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CRUDCORE.Datos
{
    public class UsuarioDatos
    {

        public UsuarioModels Obtener(string email, string clave) { 
            var oUsuario = new UsuarioModels();
            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            { 
                conexion.Open();

                SqlCommand cmd = new SqlCommand("PA_USUARIO_GET_LOGIN",conexion);
                cmd.Parameters.AddWithValue("usu_email", email);
                cmd.Parameters.AddWithValue("usu_clave", email);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oUsuario.id = Convert.ToInt32(dr["usu_id"]);                        
                        oUsuario.rut = dr["usu_rut"].ToString();
                        oUsuario.nom = dr["usu_nom"].ToString();
                        oUsuario.apepat = dr["usu_apepat"].ToString();
                        oUsuario.apemat = dr["usu_apemat"].ToString();
                        oUsuario.direccion = dr["usu_direccion"].ToString();
                        oUsuario.telefono = dr["usu_telefono"].ToString();
                        oUsuario.email = dr["usu_email"].ToString();
                        oUsuario.clave = dr["usu_clave"].ToString();
                        oUsuario.estado = Convert.ToInt32(dr["ues_estado"]);
                    }
                }
            }

            return oUsuario;

        }

    }
}
