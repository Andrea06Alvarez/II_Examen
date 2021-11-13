using Examen2_AndreaAlvarez.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_AndreaAlvarez.Modelos.DAO
{
    public class TicketDAO : Conexion 
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoTicket(Ticket ticket)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@Nombre, @Cantidad, @Fecha, @TipoDeSoporte, @NombreEstado); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 70).Value =ticket.NombreCliente;
                comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = ticket.CantidadDeTicket;
                comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = ticket.Fecha;
                comando.Parameters.Add("@TipoDeSoporte", SqlDbType.NVarChar, 100).Value = ticket.TipoDeSoporte;
                comando.Parameters.Add("@NombreEstado", SqlDbType.VarChar, 70).Value = ticket.NombreEstado;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetEstado()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GetTipo()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TIPOSOPORTE ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

    }
}
