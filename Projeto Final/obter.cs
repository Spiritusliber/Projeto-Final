using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    internal class obter
    {
        private string _descEspecie, _descricaoRaca, _CPF;

        public string descEspecie
        {
            get { return _descEspecie; }
            set { _descEspecie = value; }
        }

        public string descricaoRaca
        {
            get { return _descricaoRaca; }
            set { _descricaoRaca = value; }
        }

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        public int ObterIdCPF(string _CPF, SqlConnection conn)
        {
            string consultaSQL = "SELECT idTutor FROM Tutor WHERE CPF = @CPF";
            using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
            {
                cmd.Parameters.AddWithValue("@CPF", _CPF);
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObterIdEspecie(string _descEspecie, SqlConnection conn)
        {
            string consultaSQL = "SELECT idEspecie FROM Especie WHERE descEspecie = @descEspecie";
            using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
            {
                cmd.Parameters.AddWithValue("@descEspecie", _descEspecie);
                return (int)cmd.ExecuteScalar();
            }
        }

        public int ObterIdRaca(string _descricaoRaca, SqlConnection conn)
        {
            string consultaSQL = "SELECT idRaca FROM Raca WHERE Descricao = @descricaoRaca";
            using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
            {
                cmd.Parameters.AddWithValue("@descricaoRaca", _descricaoRaca);
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
