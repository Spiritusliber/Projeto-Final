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
    public partial class frmVet : Form
    {
        public frmVet()
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

            string consultaSQL = "INSERT INTO Veterinario (CRMV, nomeVet, enderecoVet, celularVet) VALUES (@CRMV, @nomeVet,@enderecoVet, @celularVet)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@CRMV", txtCrmv.Text);

                        cmd.Parameters.AddWithValue("@nomeVet", txtNome.Text);

                        cmd.Parameters.AddWithValue("@enderecoVet", txtEndereco.Text);

                        cmd.Parameters.AddWithValue("@celularVet", txtCelular.Text);
                        
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

            string consultaSQL = "DELETE FROM Veterinario WHERE CRMV = @CRMV";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@CRMV", txtCrmv.Text);
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

        private void CarregaGrid()
        {
            conexao.StrSql = "select * from Veterinario";
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            gridVet.DataSource = DT;
        }

        private void frmVet_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
