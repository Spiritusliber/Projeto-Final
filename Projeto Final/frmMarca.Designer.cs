namespace Projeto_Final
{
    partial class frmMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBanho = new System.Windows.Forms.CheckBox();
            this.chkTosa = new System.Windows.Forms.CheckBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFechado = new System.Windows.Forms.RadioButton();
            this.rdbAberto = new System.Windows.Forms.RadioButton();
            this.lblTutor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.txtCRMV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridHorario = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcar Horário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(151, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serviços";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkBanho
            // 
            this.chkBanho.AutoSize = true;
            this.chkBanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chkBanho.Location = new System.Drawing.Point(29, 152);
            this.chkBanho.Name = "chkBanho";
            this.chkBanho.Size = new System.Drawing.Size(189, 26);
            this.chkBanho.TabIndex = 5;
            this.chkBanho.Text = "Banho        R$85,00";
            this.chkBanho.UseVisualStyleBackColor = true;
            // 
            // chkTosa
            // 
            this.chkTosa.AutoSize = true;
            this.chkTosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chkTosa.Location = new System.Drawing.Point(29, 185);
            this.chkTosa.Name = "chkTosa";
            this.chkTosa.Size = new System.Drawing.Size(188, 26);
            this.chkTosa.TabIndex = 6;
            this.chkTosa.Text = "Tosa          R$90,00";
            this.chkTosa.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            this.chkConsulta.AutoSize = true;
            this.chkConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chkConsulta.Location = new System.Drawing.Point(29, 221);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.Size = new System.Drawing.Size(188, 26);
            this.chkConsulta.TabIndex = 7;
            this.chkConsulta.Text = "Consulta  R$150,00";
            this.chkConsulta.UseVisualStyleBackColor = true;
            this.chkConsulta.CheckedChanged += new System.EventHandler(this.chkConsulta_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFechado);
            this.groupBox1.Controls.Add(this.rdbAberto);
            this.groupBox1.Controls.Add(this.lblTutor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCodPet);
            this.groupBox1.Controls.Add(this.txtCRMV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(29, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rdbFechado
            // 
            this.rdbFechado.AutoSize = true;
            this.rdbFechado.Location = new System.Drawing.Point(133, 146);
            this.rdbFechado.Name = "rdbFechado";
            this.rdbFechado.Size = new System.Drawing.Size(67, 17);
            this.rdbFechado.TabIndex = 10;
            this.rdbFechado.TabStop = true;
            this.rdbFechado.Text = "Fechado";
            this.rdbFechado.UseVisualStyleBackColor = true;
            this.rdbFechado.CheckedChanged += new System.EventHandler(this.rdbFechado_CheckedChanged);
            // 
            // rdbAberto
            // 
            this.rdbAberto.AutoSize = true;
            this.rdbAberto.Location = new System.Drawing.Point(71, 146);
            this.rdbAberto.Name = "rdbAberto";
            this.rdbAberto.Size = new System.Drawing.Size(56, 17);
            this.rdbAberto.TabIndex = 9;
            this.rdbAberto.TabStop = true;
            this.rdbAberto.Text = "Aberto";
            this.rdbAberto.UseVisualStyleBackColor = true;
            this.rdbAberto.CheckedChanged += new System.EventHandler(this.rdbAberto_CheckedChanged);
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(61, 116);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(55, 13);
            this.lblTutor.TabIndex = 8;
            this.lblTutor.Text = "________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "________";
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(50, 73);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(100, 20);
            this.txtCodPet.TabIndex = 5;
            // 
            // txtCRMV
            // 
            this.txtCRMV.Location = new System.Drawing.Point(50, 30);
            this.txtCRMV.Name = "txtCRMV";
            this.txtCRMV.Size = new System.Drawing.Size(100, 20);
            this.txtCRMV.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Situação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tutor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CodPet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CRMV";
            // 
            // gridHorario
            // 
            this.gridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHorario.Location = new System.Drawing.Point(35, 458);
            this.gridHorario.Name = "gridHorario";
            this.gridHorario.Size = new System.Drawing.Size(266, 178);
            this.gridHorario.TabIndex = 11;
            this.gridHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHorario_CellContentClick);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(35, 654);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(110, 23);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(191, 654);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtpDia
            // 
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(68, 61);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(77, 20);
            this.dtpDia.TabIndex = 14;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(206, 61);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(66, 20);
            this.dtpHora.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(25, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "idConsulta";
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Location = new System.Drawing.Point(126, 96);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtIdConsulta.TabIndex = 17;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 699);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gridHorario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkConsulta);
            this.Controls.Add(this.chkTosa);
            this.Controls.Add(this.chkBanho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBanho;
        private System.Windows.Forms.CheckBox chkTosa;
        private System.Windows.Forms.CheckBox chkConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.TextBox txtCRMV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbFechado;
        private System.Windows.Forms.RadioButton rdbAberto;
        private System.Windows.Forms.DataGridView gridHorario;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdConsulta;
    }
}