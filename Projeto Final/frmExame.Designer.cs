namespace Projeto_Final
{
    partial class frmExame
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
            this.codExame = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtcodExame = new System.Windows.Forms.TextBox();
            this.cboDescExame = new System.Windows.Forms.ComboBox();
            this.btnaddExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codExame
            // 
            this.codExame.AutoSize = true;
            this.codExame.Location = new System.Drawing.Point(34, 48);
            this.codExame.Name = "codExame";
            this.codExame.Size = new System.Drawing.Size(40, 13);
            this.codExame.TabIndex = 0;
            this.codExame.Text = "Codigo";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(34, 78);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(55, 13);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "Descrição";
            // 
            // txtcodExame
            // 
            this.txtcodExame.Location = new System.Drawing.Point(93, 48);
            this.txtcodExame.Name = "txtcodExame";
            this.txtcodExame.Size = new System.Drawing.Size(121, 20);
            this.txtcodExame.TabIndex = 2;
            // 
            // cboDescExame
            // 
            this.cboDescExame.FormattingEnabled = true;
            this.cboDescExame.Location = new System.Drawing.Point(93, 75);
            this.cboDescExame.Name = "cboDescExame";
            this.cboDescExame.Size = new System.Drawing.Size(121, 21);
            this.cboDescExame.TabIndex = 3;
            // 
            // btnaddExame
            // 
            this.btnaddExame.Location = new System.Drawing.Point(37, 131);
            this.btnaddExame.Name = "btnaddExame";
            this.btnaddExame.Size = new System.Drawing.Size(198, 23);
            this.btnaddExame.TabIndex = 4;
            this.btnaddExame.Text = "Adicionar";
            this.btnaddExame.UseVisualStyleBackColor = true;
            this.btnaddExame.Click += new System.EventHandler(this.btnaddExame_Click);
            // 
            // frmExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 172);
            this.Controls.Add(this.btnaddExame);
            this.Controls.Add(this.cboDescExame);
            this.Controls.Add(this.txtcodExame);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.codExame);
            this.Name = "frmExame";
            this.Text = "frmExame";
            this.Load += new System.EventHandler(this.frmExame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codExame;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtcodExame;
        private System.Windows.Forms.ComboBox cboDescExame;
        private System.Windows.Forms.Button btnaddExame;
    }
}