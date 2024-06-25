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
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        StringBuilder cmdSql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        DataGridView DataGrid;

        private void PreencherComboBoxExame()
        {
            conexao conexao = new conexao();
            conexao.StrSql = "SELECT descExame FROM Exame";

            DS = conexao.RetornarDataSet();
            if (DS.Tables.Count > 0)
            {
                DataTable DT = DS.Tables[0];
                cboExamesAtend.DataSource = DT;
                cboExamesAtend.DisplayMember = "descExame";
                cboExamesAtend.ValueMember = "descExame";

                if (DS.Tables.Count > 0)
                {
                    cboExamesAtend.SelectedIndex = 0;
                }
            }

            else
            {
                cboExamesAtend.DataSource = null;
            }
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();
            obter obter = new obter();

            string consultaSQL = "INSERT INTO Atendimento (dtaAtend, hrAtend, descAtend, idPet, CPF, codExame) VALUES (@dtaAtend, @hrAtend, @descAtend, @idPet, @CPF, @codExame)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    int codExame = obter.ObterIdExame(cboExamesAtend.Text, conn);
                    int idTutor = obter.ObterIdCPF(txtTutorAtend.Text, conn);

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@dtaAtend", Convert.ToDateTime(dtpDiaAtendimento.Text));

                        cmd.Parameters.AddWithValue("@hrAtend", Convert.ToDateTime(dtpHrAtendimento.Text));

                        cmd.Parameters.AddWithValue("@descAtend", txtDescAtend.Text);

                        cmd.Parameters.AddWithValue("@idPet", txtCodPetAtend.Text);

                        cmd.Parameters.AddWithValue("@CPF", idTutor);

                        cmd.Parameters.AddWithValue("@codExame", codExame);
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
        }

        private void CarregaGrid()
        {
            conexao.StrSql = "select * from Atendimento";
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            gridAtend.DataSource = DT;
        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            PreencherComboBoxExame();
            CarregaGrid();
        }
    }
}
