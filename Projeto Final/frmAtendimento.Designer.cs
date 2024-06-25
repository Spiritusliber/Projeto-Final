namespace Projeto_Final
{
    partial class frmAtendimento
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
            this.txtCodPetAtend = new System.Windows.Forms.TextBox();
            this.txtTutorAtend = new System.Windows.Forms.TextBox();
            this.cboExamesAtend = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridAtend = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescAtend = new System.Windows.Forms.TextBox();
            this.dtpDiaAtendimento = new System.Windows.Forms.DateTimePicker();
            this.dtpHrAtendimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtend)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atendimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Do Pet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(149, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora";
            // 
            // txtCodPetAtend
            // 
            this.txtCodPetAtend.Location = new System.Drawing.Point(156, 85);
            this.txtCodPetAtend.Name = "txtCodPetAtend";
            this.txtCodPetAtend.Size = new System.Drawing.Size(131, 20);
            this.txtCodPetAtend.TabIndex = 5;
            // 
            // txtTutorAtend
            // 
            this.txtTutorAtend.Location = new System.Drawing.Point(84, 120);
            this.txtTutorAtend.Name = "txtTutorAtend";
            this.txtTutorAtend.Size = new System.Drawing.Size(131, 20);
            this.txtTutorAtend.TabIndex = 6;
            // 
            // cboExamesAtend
            // 
            this.cboExamesAtend.FormattingEnabled = true;
            this.cboExamesAtend.Location = new System.Drawing.Point(119, 298);
            this.cboExamesAtend.Name = "cboExamesAtend";
            this.cboExamesAtend.Size = new System.Drawing.Size(134, 21);
            this.cboExamesAtend.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(23, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exames";
            // 
            // gridAtend
            // 
            this.gridAtend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAtend.Location = new System.Drawing.Point(27, 337);
            this.gridAtend.Name = "gridAtend";
            this.gridAtend.Size = new System.Drawing.Size(306, 135);
            this.gridAtend.TabIndex = 11;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(84, 478);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(172, 45);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(23, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descrição";
            // 
            // txtDescAtend
            // 
            this.txtDescAtend.Location = new System.Drawing.Point(119, 196);
            this.txtDescAtend.Multiline = true;
            this.txtDescAtend.Name = "txtDescAtend";
            this.txtDescAtend.Size = new System.Drawing.Size(226, 96);
            this.txtDescAtend.TabIndex = 14;
            // 
            // dtpDiaAtendimento
            // 
            this.dtpDiaAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiaAtendimento.Location = new System.Drawing.Point(60, 153);
            this.dtpDiaAtendimento.Name = "dtpDiaAtendimento";
            this.dtpDiaAtendimento.Size = new System.Drawing.Size(83, 20);
            this.dtpDiaAtendimento.TabIndex = 15;
            // 
            // dtpHrAtendimento
            // 
            this.dtpHrAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHrAtendimento.Location = new System.Drawing.Point(204, 153);
            this.dtpHrAtendimento.Name = "dtpHrAtendimento";
            this.dtpHrAtendimento.Size = new System.Drawing.Size(68, 20);
            this.dtpHrAtendimento.TabIndex = 16;
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 535);
            this.Controls.Add(this.dtpHrAtendimento);
            this.Controls.Add(this.dtpDiaAtendimento);
            this.Controls.Add(this.txtDescAtend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gridAtend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboExamesAtend);
            this.Controls.Add(this.txtTutorAtend);
            this.Controls.Add(this.txtCodPetAtend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAtendimento";
            this.Text = "frmAtendimento";
            this.Load += new System.EventHandler(this.frmAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodPetAtend;
        private System.Windows.Forms.TextBox txtTutorAtend;
        private System.Windows.Forms.ComboBox cboExamesAtend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridAtend;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescAtend;
        private System.Windows.Forms.DateTimePicker dtpDiaAtendimento;
        private System.Windows.Forms.DateTimePicker dtpHrAtendimento;
    }
}