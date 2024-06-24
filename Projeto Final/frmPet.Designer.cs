namespace Projeto_Final
{
    partial class frmPet
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.rdbFemea = new System.Windows.Forms.RadioButton();
            this.txtNascPet = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.cboRaca = new System.Windows.Forms.ComboBox();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.gridPet = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de Pet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(28, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Espécie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Raça";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Situação";
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMacho.Location = new System.Drawing.Point(54, 146);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(72, 22);
            this.rdbMacho.TabIndex = 8;
            this.rdbMacho.TabStop = true;
            this.rdbMacho.Text = "Macho";
            this.rdbMacho.UseVisualStyleBackColor = true;
            this.rdbMacho.CheckedChanged += new System.EventHandler(this.rdbMacho_CheckedChanged);
            // 
            // rdbFemea
            // 
            this.rdbFemea.AutoSize = true;
            this.rdbFemea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemea.Location = new System.Drawing.Point(179, 146);
            this.rdbFemea.Name = "rdbFemea";
            this.rdbFemea.Size = new System.Drawing.Size(72, 22);
            this.rdbFemea.TabIndex = 9;
            this.rdbFemea.TabStop = true;
            this.rdbFemea.Text = "Femea";
            this.rdbFemea.UseVisualStyleBackColor = true;
            this.rdbFemea.CheckedChanged += new System.EventHandler(this.rdbFemea_CheckedChanged);
            // 
            // txtNascPet
            // 
            this.txtNascPet.Location = new System.Drawing.Point(155, 184);
            this.txtNascPet.Name = "txtNascPet";
            this.txtNascPet.Size = new System.Drawing.Size(147, 20);
            this.txtNascPet.TabIndex = 10;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(155, 216);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(147, 20);
            this.txtCPF.TabIndex = 11;
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(155, 113);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(147, 20);
            this.txtNomePet.TabIndex = 12;
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(155, 79);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(147, 20);
            this.txtCodPet.TabIndex = 13;
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(155, 249);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(147, 21);
            this.cboEspecie.TabIndex = 14;
            // 
            // cboRaca
            // 
            this.cboRaca.FormattingEnabled = true;
            this.cboRaca.Location = new System.Drawing.Point(155, 276);
            this.cboRaca.Name = "cboRaca";
            this.cboRaca.Size = new System.Drawing.Size(147, 21);
            this.cboRaca.TabIndex = 15;
            // 
            // cboSituacao
            // 
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(155, 309);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(147, 21);
            this.cboSituacao.TabIndex = 16;
            // 
            // gridPet
            // 
            this.gridPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPet.Location = new System.Drawing.Point(30, 350);
            this.gridPet.Name = "gridPet";
            this.gridPet.RowHeadersWidth = 62;
            this.gridPet.Size = new System.Drawing.Size(310, 95);
            this.gridPet.TabIndex = 17;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(30, 462);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(91, 42);
            this.btnIncluir.TabIndex = 18;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(134, 462);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 42);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(247, 462);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 42);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 573);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gridPet);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.cboRaca);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.txtCodPet);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNascPet);
            this.Controls.Add(this.rdbFemea);
            this.Controls.Add(this.rdbMacho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPet";
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.frmPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbMacho;
        private System.Windows.Forms.RadioButton rdbFemea;
        private System.Windows.Forms.TextBox txtNascPet;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboRaca;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.DataGridView gridPet;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}