namespace Cadastro_de_alunos
{
    partial class periodoCad
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
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtHrTer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHrIni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.Location = new System.Drawing.Point(435, 257);
            this.btnExcluir2.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir2.TabIndex = 99;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = true;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // dgvPeriodos
            // 
            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodos.Location = new System.Drawing.Point(219, 49);
            this.dgvPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeriodos.Name = "dgvPeriodos";
            this.dgvPeriodos.Size = new System.Drawing.Size(316, 200);
            this.dgvPeriodos.TabIndex = 105;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(327, 257);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 97;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(219, 257);
            this.btnCad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(100, 28);
            this.btnCad.TabIndex = 96;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtHrTer
            // 
            this.txtHrTer.Location = new System.Drawing.Point(13, 188);
            this.txtHrTer.Margin = new System.Windows.Forms.Padding(4);
            this.txtHrTer.Name = "txtHrTer";
            this.txtHrTer.Size = new System.Drawing.Size(185, 22);
            this.txtHrTer.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 104;
            this.label6.Text = "Hora (Término)*:";
            // 
            // txtHrIni
            // 
            this.txtHrIni.Location = new System.Drawing.Point(16, 134);
            this.txtHrIni.Margin = new System.Windows.Forms.Padding(4);
            this.txtHrIni.Name = "txtHrIni";
            this.txtHrIni.Size = new System.Drawing.Size(185, 22);
            this.txtHrIni.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Hora (Início)*:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 82);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 22);
            this.txtNome.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Nome*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = "Cadastro de Períodos";
            // 
            // periodoCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 301);
            this.Controls.Add(this.btnExcluir2);
            this.Controls.Add(this.dgvPeriodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtHrTer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHrIni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "periodoCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Períodos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.DataGridView dgvPeriodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtHrTer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHrIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}