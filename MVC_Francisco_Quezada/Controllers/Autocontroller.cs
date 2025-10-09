using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MVC_Francisco_Quezada.Models;
using MVC_Francisco_Quezada.View;


namespace MVC_Francisco_Quezada.Controllers
{
    public class AutoController
    {
        private string connectionString = "Data Source=DESKTOP-N7R3V4G;Initial Catalog=Autos_Narla;Integrated Security=True";

        public List<Auto> ListarVehiculo()
        {
            List<Auto> lista = new List<Auto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(
                         @"SELECT AutoID, Codigo, Marca, Modelo, AñoFabricacion, AñoProduccion, 
                                 Cilindraje, TipoVehiculo, PrecioVenta, PrecioCompra, 
                                 DescuentoAplicado, CategoriaID, ProveedorID, Stock
                          FROM Auto", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Auto a = new Auto
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
                    lista.Add(a);
                }

            }

            return lista;
        }

        public void InsertarVehiculo(Auto nuevoAuto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 🔸 Validar si ya hay 4 autos del mismo modelo
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Auto WHERE Modelo = @Modelo", conn);
                checkCmd.Parameters.AddWithValue("@Modelo", nuevoAuto.Modelo);
                int cantidad = (int)checkCmd.ExecuteScalar();

                if (cantidad >= 4)
                {
                    throw new Exception("Ya existen 4 unidades del mismo modelo. No se pueden agregar más.");
                }

                // 🔸 Insertar el nuevo auto
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Auto 
                    (Codigo, Marca, Modelo, AñoFabricacion, AñoProduccion, Cilindraje, 
                     TipoVehiculo, PrecioCompra, PrecioVenta, DescuentoAplicado, 
                     CategoriaID, ProveedorID, Stock)
                    VALUES 
                    (@Codigo, @Marca, @Modelo, @AñoFabricacion, @AñoProduccion, @Cilindraje,
                     @TipoVehiculo, @PrecioCompra, @PrecioVenta, @DescuentoAplicado,
                     @CategoriaID, @ProveedorID, @Stock)", conn);

                cmd.Parameters.AddWithValue("@Codigo", nuevoAuto.Codigo);
                cmd.Parameters.AddWithValue("@Marca", nuevoAuto.Marca);
                cmd.Parameters.AddWithValue("@Modelo", nuevoAuto.Modelo);
                cmd.Parameters.AddWithValue("@AñoFabricacion", nuevoAuto.AñoFabricacion);
                cmd.Parameters.AddWithValue("@AñoProduccion", nuevoAuto.AñoProduccion);
                cmd.Parameters.AddWithValue("@Cilindraje", nuevoAuto.Cilindraje);
                cmd.Parameters.AddWithValue("@TipoVehiculo", nuevoAuto.TipoVehiculo);
                cmd.Parameters.AddWithValue("@PrecioCompra", nuevoAuto.PrecioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", nuevoAuto.PrecioVenta);
                cmd.Parameters.AddWithValue("@DescuentoAplicado", nuevoAuto.DescuentoAplicado);
                cmd.Parameters.AddWithValue("@CategoriaID", nuevoAuto.CategoriaID);
                cmd.Parameters.AddWithValue("@ProveedorID", nuevoAuto.ProveedorID);
                cmd.Parameters.AddWithValue("@Stock", nuevoAuto.Stock);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
