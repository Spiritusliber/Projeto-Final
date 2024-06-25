using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    internal class obter
    {
        private string _descEspecie, _descricaoRaca, _CPF, _descExame, _Servico ;
        private double _Banho, _Tosa, _Consulta;


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

        public double Banho
        {
            get { return _Banho; }
            set { _Banho = value; }
        }

        public double Tosa
        {
            get { return _Tosa;}
            set { _Tosa = value; }
        }
        public double Consulta
        {
            get { return _Consulta; }
            set { _Consulta = value; } 
        }
        public string Servico
        {
            get { return _Servico; }
            set { _Servico = value;} 
        }

        public string descExame
        {
            get { return _descExame; }
            set { _descExame = value; }
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

        public int ObterIdExame(string _descExame, SqlConnection conn)
        {
            string consultaSQL = "SELECT codExame FROM Exame WHERE descExame = @descExame";
            using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
            {
                cmd.Parameters.AddWithValue("@descExame", _descExame);
                return (int)cmd.ExecuteScalar();
            }
        }

        public double obterValorServico()
        {
            double ValorServico;
            ValorServico = _Banho + _Tosa + _Consulta;

            return ValorServico;
        }
        public string obterServico()
        {
            Servico = _Servico;

            return Servico;
        }
    }
}
