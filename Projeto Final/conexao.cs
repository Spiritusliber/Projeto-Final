using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj16
{
    internal class conexao
    {
        private string _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }
        private string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\pichau\\source\\repos\\Projeto Final\\Projeto Final\\Database2.mdf\";Integrated Security=True";

        //Privado para limitar o acesso ao banco de dados
        public SqlConnection AbrirBanco()
        {
            SqlConnection Conn = new SqlConnection(); // Instanciando a Classe
            Conn.ConnectionString = strConexao;
            Conn.Open();//Método sem Parametros
            return Conn; // Retornando o valor obtido
        }

        public void Fechar() // Void usado para não retornar nada
        {
            SqlConnection Conn = new SqlConnection();

            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();

            }
        }//Conexão do banco deve ser breve


        public DataSet RetornarDataSet()
        {
            SqlConnection conn2 = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            SqlDataAdapter DA = new SqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                conn2 = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn2;

                DA.SelectCommand = Cmd;
                DA.Fill(DS);

                return DS;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn2.Close();
            }
        }

        public SqlDataReader RetornarDataReader()
        {
            SqlConnection Conn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();

            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;

                return Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExecutarCmd()
        {
            SqlConnection Conn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();

            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandText = Convert.ToString(CommandType.Text);
                Cmd.Connection = Conn;

                return Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
