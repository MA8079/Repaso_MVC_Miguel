using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Repaso_MVC_Miguel.Models
{
    public class EntradaDAO
    {
        //Conexion
        String Conexion = @"Server=LAPTOP-NKDVUSVE\SQLEXPRESS;Database=MiercolesDB;Integrated Security=true";
        public List<Entrada> CargarEntrada()
        {
            List<Entrada> entradas = new List<Entrada>();
            SqlConnection Con = new SqlConnection(Conexion);
            SqlCommand Cm = new SqlCommand("Select * from TblEntrada",Con);
            Con.Open();
            SqlDataReader Dr = Cm.ExecuteReader();
            while (Dr.Read())
            {
                Entrada entrada = new Entrada();
                entrada.IdEntrada = int.Parse(Dr[0].ToString());
                entrada.Cantidad = int.Parse(Dr[1].ToString());
                entrada.Fecha = Dr[2].ToString();
                entrada.Hora = Dr[3].ToString();
                entrada.IdProducto = int.Parse(Dr[4].ToString());
                entradas.Add(entrada);
            }
            Con.Close();
            return entradas;
        }

    }
}