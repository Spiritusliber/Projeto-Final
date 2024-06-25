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
    public partial class frmTutor : Form
    {
        public frmTutor()
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

            string consultaSQL = "INSERT INTO Tutor (CPF, nomeTutor, celularTutor, emailTutor) VALUES (@CPF, @nomeTutor, @celularTutor, @emailTutor)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);

                        cmd.Parameters.AddWithValue("@nomeTutor", txtNome.Text);

                        cmd.Parameters.AddWithValue("@celularTutor", txtCelular.Text);

                        cmd.Parameters.AddWithValue("@emailTutor", txtEmail.Text);
                        //conn.Open();
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
        } // Adicionando os dados no Banco

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();

            string consultaSQL = "DELETE FROM Tutor WHERE CPF = @CPF";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);
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
        }// Excluir dados no Banco

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            obter obter = new obter();

            string consultaSQL = "select nomePet, sexoPet, NascPet from Pet where idTutor like @idTutor";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    int idTutor = obter.ObterIdCPF(txtCpf.Text, conn);
                    conexao.StrSql = "select nomePet, sexoPet, NascPet from Pet";
                    DS = conexao.RetornarDataSet();
                    DT = DS.Tables[0];
                    gridTutor.DataSource = DT;
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@idTutor", idTutor);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            gridTutor.DataSource = dt;
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
        private void alterarDB()
        {
            conexao conexao = new conexao();

            string consultaSQL = "UPDATE Tutor SET nomeTutor = @nomeTutor, celularTutor = @celularTutor, emailTutor = @emailTutor where CPF = @CPF";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@CPF", txtCpf.Text);

                        cmd.Parameters.AddWithValue("@nomeTutor", txtNome.Text);

                        cmd.Parameters.AddWithValue("@celularTutor", txtCelular.Text);

                        cmd.Parameters.AddWithValue("@emailTutor", txtEmail.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dados Alterados com Sucesso!");

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDB();
        }

    }
}
