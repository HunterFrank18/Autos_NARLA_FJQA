using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Francisco_Quezada.Models;
using MVC_Francisco_Quezada.View;
using System.Data.SqlClient;

namespace MVC_Francisco_Quezada.Controllers
{
    class DetVehiculoController
    {
        private string connectionString = "Data Source=DESKTOP-N7R3V4G;Initial Catalog=Autos_Narla;Integrated Security=True";

        public Auto ObtenerVehiculoPorCodigo(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT Marca, Modelo, AñoFabricacion, PrecioVenta 
                      FROM Auto 
                      WHERE Codigo = @Codigo", conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Auto
                    {
                        Marca = reader.GetString(0),
                        Modelo = reader.GetString(1),
                        AñoFabricacion = reader.GetInt32(2),
                        PrecioVenta = reader.GetDecimal(3)
                    };
                }
                return null;
            }
        }
    }
}
