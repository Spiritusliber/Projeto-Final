using proj16;
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

namespace Projeto_Final
{
    public partial class frmEspecie : Form
    {
        public frmEspecie()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        StringBuilder cmdSql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        DataGridView DataGrid;

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();

            string consultaSQL = "INSERT INTO Especie (idEspecie, descEspecie) VALUES (@idEspecie, @descEspecie)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@idEspecie", txtCodesp.Text);

                        cmd.Parameters.AddWithValue("@descEspecie", txtDescricao.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dados Cadastrados com Sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);

            }
            finally
            {
                conexao.Fechar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();

            string consultaSQL = "DELETE FROM Especie WHERE idEspecie = @idEspecie";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@idEspecie", txtCodesp.Text);
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);

            }
            finally
            {
                conexao.Fechar();
            }
        }
    }
}
