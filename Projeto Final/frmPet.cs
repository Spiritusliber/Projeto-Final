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
    public partial class frmPet : Form
    {
        public frmPet()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        obter obter = new obter();
        StringBuilder cmdSql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        DataGridView DataGrid;
        String Genero = "";

        private void rdbMacho_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "Macho";
        }

        private void rdbFemea_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "Femea";
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();
            obter obter = new obter();

            string consultaSQL = "INSERT INTO Pet (idPet, nomePet, sexoPet, NascPet, idTutor, idEspecie, idRaca) VALUES (@idPet, @nomePet, @sexoPet, @nascPet, @idTutor, @idEspecie, @idRaca)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    int idEspecie = obter.ObterIdEspecie(cboEspecie.Text, conn);
                    int idRaca = obter.ObterIdRaca(cboRaca.Text, conn);
                    int idTutor = obter.ObterIdCPF(txtCPF.Text, conn);

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPet", txtCodPet.Text);

                        cmd.Parameters.AddWithValue("@nomePet", txtNomePet.Text);

                        cmd.Parameters.AddWithValue("@sexoPet", Genero);

                        cmd.Parameters.AddWithValue("@nascPet", Convert.ToDateTime(txtNascPet.Text));

                        cmd.Parameters.AddWithValue("@idTutor", idTutor);

                        cmd.Parameters.AddWithValue("@idEspecie", idEspecie);

                        cmd.Parameters.AddWithValue("@idRaca", idRaca);


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

        private void alterarDB()
        {
            conexao conexao = new conexao();

            string consultaSQL = "UPDATE Pet SET nomePet = @nomePet, sexoPet = @sexoPet, NascPet = @nascPet where idPet = @idPet";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPet", txtCodPet.Text);

                        cmd.Parameters.AddWithValue("@nomePet", txtNomePet.Text);

                        cmd.Parameters.AddWithValue("@sexoPet", Genero);

                        cmd.Parameters.AddWithValue("@nascPet", txtNascPet.Text);

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

        private void PreencherComboBoxEspecie()
        {
            conexao conexao = new conexao();
            conexao.StrSql = "SELECT idEspecie, descEspecie FROM Especie";

            DS = conexao.RetornarDataSet();
            if (DS.Tables.Count > 0)
            {
                DataTable DT = DS.Tables[0];
                cboEspecie.DataSource = DT;
                cboEspecie.DisplayMember = "descEspecie";
                cboEspecie.ValueMember = "idEspecie";

                cboEspecie.SelectedIndexChanged += cboEspecie_SelectedIndexChanged;
                if (DS.Tables.Count > 0)
                {
                    cboEspecie.SelectedIndex = 0;
                }
            }

            else
            {
                cboEspecie.DataSource = null;
            }
        }
        private void PreencherComboBoxRaca(int idEspecie)
        {
            conexao conexao = new conexao();
            conexao.StrSql = "SELECT idRaca, Descricao FROM Raca where idEspecie like @idEspecie";
            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(conexao.StrSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idEspecie", idEspecie);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboRaca.DataSource = dt;
                        cboRaca.DisplayMember = "Descricao";
                        cboRaca.ValueMember = "idRaca";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o ComboBox" + ex.Message);
            }
        }

        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idEspecie = Convert.ToInt32(cboEspecie.SelectedValue);

            PreencherComboBoxRaca(idEspecie);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                //Instanciando a conexao do banco de dados
                conexao conexao = new conexao();

                string consultaSQL = "DELETE FROM Pet WHERE idPet = @idPet";

                try
                {
                    using (SqlConnection conn = conexao.AbrirBanco())
                    {
                        using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                        {
                            cmd.Parameters.AddWithValue("@idPet", txtCodPet.Text);
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

        private void frmPet_Load(object sender, EventArgs e)
        {
            PreencherComboBoxEspecie();
        }
    }
}
