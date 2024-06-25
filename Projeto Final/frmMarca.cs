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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        string situacao = "";
        conexao conexao = new conexao();
        StringBuilder cmdSql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        DataGridView DataGrid;

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsulta.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            CarregaGrid();
        }

        public void rdbAberto_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Aberto";
        }

        public void rdbFechado_CheckedChanged(object sender, EventArgs e)
        {
            situacao = "Fechado";
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            obter obter = new obter();
            if (chkBanho.Checked == true)
            {
                obter.Banho = 85;
                obter.Servico += "Banho, ";
            }
            else
            {
                obter.Banho = 0;
            }

            if (chkTosa.Checked == true)
            {
                obter.Tosa = 90.00;
                obter.Servico += "Tosa, ";
            }
            else
            {
                obter.Tosa = 0;
            }

            if (chkConsulta.Checked == true)
            {
                obter.Consulta = 150.00;
                obter.Servico += "Consulta";
            }
            else
            {
                obter.Consulta = 0;
            }

            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();
            string consultaSQL = "INSERT INTO Consulta (idConsulta, Data, Horario, Servico, Preco, situacao, CRMV, idPet) VALUES (@idConsulta, @Data, @Horario, @Servico, @Preco, @situacao, @CRMV, @idPet)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        string Servico = obter.obterServico();
                        double Preco = obter.obterValorServico();

                        cmd.Parameters.AddWithValue("@idConsulta", txtIdConsulta.Text);

                        cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dtpDia.Text));

                        cmd.Parameters.AddWithValue("@Horario", Convert.ToDateTime(dtpHora.Text));

                        cmd.Parameters.AddWithValue("@Servico", Servico);

                        cmd.Parameters.AddWithValue("@Preco", Preco);

                        cmd.Parameters.AddWithValue("@Situacao", situacao);

                        cmd.Parameters.AddWithValue("@CRMV", txtCRMV.Text);

                        cmd.Parameters.AddWithValue("@idPet", txtCodPet.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dados Cadastrados com Sucesso!");
                    CarregaGrid();

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
            conexao.StrSql = "select * from Consulta";
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            gridHorario.DataSource = DT;
        }

        private void gridHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();

            string consultaSQL = "DELETE FROM Consulta WHERE idConsulta = @Consulta";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@Consulta", txtIdConsulta.Text);
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso.");
                            CarregaGrid();
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
