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
    public partial class frmExame : Form
    {
        public frmExame()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        StringBuilder cmdSql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        DataGridView DataGrid;

        private void btnaddExame_Click(object sender, EventArgs e)
        {
            //Instanciando a conexao do banco de dados
            conexao conexao = new conexao();

            string consultaSQL = "INSERT INTO Exame (codExame, descExame) VALUES (@codExame, @descExame)";

            try
            {
                using (SqlConnection conn = conexao.AbrirBanco())
                {
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@codExame", txtcodExame.Text);

                        cmd.Parameters.AddWithValue("@descExame", cboDescExame.Text);

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

        private void PreencherComboBox()
        {
            conexao conexao = new conexao();
            conexao.StrSql = "SELECT descExame FROM Exame";

            DS = conexao.RetornarDataSet();
            if (DS.Tables.Count > 0)
            {
                DataTable DT = DS.Tables[0];
                cboDescExame.DataSource = DT;
                cboDescExame.DisplayMember = "descExame";
                cboDescExame.ValueMember = "descExame";
            }
            else
            {
                cboDescExame.DataSource = null;
            }
        }
        private void frmExame_Load(object sender, EventArgs e)
        {
            PreencherComboBox();
        }
    }
}
