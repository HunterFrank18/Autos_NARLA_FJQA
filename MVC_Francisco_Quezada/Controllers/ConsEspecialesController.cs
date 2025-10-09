using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Francisco_Quezada.Models;
using System.Data.SqlClient;

namespace MVC_Francisco_Quezada.Controllers
{
    class ConsEspecialesController
    {
        private string connectionString = "Data Source=DESKTOP-N7R3V4G;Initial Catalog=Autos_Narla;Integrated Security=True";

        public Auto VehiculoMasAntiguo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 * FROM Auto ORDER BY AñoFabricacion ASC", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Auto
                    {
                        AutoID = reader.GetInt32(0),
                        Codigo = reader.GetInt32(1),
                        Marca = reader.GetString(2),
                        Modelo = reader.GetString(3),
                        AñoFabricacion = reader.GetInt32(4),
                        AñoProduccion = reader.GetInt32(5),
                        Cilindraje = reader.GetDecimal(6),
                        TipoVehiculo = reader.GetString(7),
                        PrecioVenta = reader.GetDecimal(8),
                        PrecioCompra = reader.GetDecimal(9),
                        DescuentoAplicado = reader.GetDecimal(10),
                        CategoriaID = reader.GetInt32(11),
                        ProveedorID = reader.GetInt32(12),
                        Stock = reader.GetInt32(13)
                    };
                }
                return null;
            }
        }

        public Auto VehiculoMayorCilindraje()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 * FROM Auto ORDER BY Cilindraje DESC", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Auto
                    {
                        AutoID = reader.GetInt32(0),
                        Codigo = reader.GetInt32(1),
                        Marca = reader.GetString(2),
                        Modelo = reader.GetString(3),
                        AñoFabricacion = reader.GetInt32(4),
                        AñoProduccion = reader.GetInt32(5),
                        Cilindraje = reader.GetDecimal(6),
                        TipoVehiculo = reader.GetString(7),
                        PrecioVenta = reader.GetDecimal(8),
                        PrecioCompra = reader.GetDecimal(9),
                        DescuentoAplicado = reader.GetDecimal(10),
                        CategoriaID = reader.GetInt32(11),
                        ProveedorID = reader.GetInt32(12),
                        Stock = reader.GetInt32(13)
                    };
                }
                return null;
            }
        }

        public Auto VehiculoPrecioMasBajo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 * FROM Auto ORDER BY PrecioVenta ASC", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Auto
                    {
                        AutoID = reader.GetInt32(0),
                        Codigo = reader.GetInt32(1),
                        Marca = reader.GetString(2),
                        Modelo = reader.GetString(3),
                        AñoFabricacion = reader.GetInt32(4),
                        AñoProduccion = reader.GetInt32(5),
                        Cilindraje = reader.GetDecimal(6),
                        TipoVehiculo = reader.GetString(7),
                        PrecioVenta = reader.GetDecimal(8),
                        PrecioCompra = reader.GetDecimal(9),
                        DescuentoAplicado = reader.GetDecimal(10),
                        CategoriaID = reader.GetInt32(11),
                        ProveedorID = reader.GetInt32(12),
                        Stock = reader.GetInt32(13)
                    };
                }
                return null;
            }
        }
    }
}

