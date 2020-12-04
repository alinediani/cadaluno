namespace Cadastro_de_alunos
{
    partial class materiaCad
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.Location = new System.Drawing.Point(223, 219);
            this.btnExcluir2.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir2.TabIndex = 80;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = true;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(220, 82);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(321, 129);
            this.dgvMaterias.TabIndex = 92;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(331, 219);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 78;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(439, 219);
            this.btnCad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(100, 28);
            this.btnCad.TabIndex = 77;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(16, 189);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(185, 22);
            this.txtProfessor.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "Professor*:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(16, 134);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(185, 22);
            this.txtPeriodo.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Período*:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 82);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 22);
            this.txtNome.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nome*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = "Cadastro de Matérias";
            // 
            // materiaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 258);
            this.Controls.Add(this.btnExcluir2);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "materiaCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Matérias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.materiaCad_FormClosed);
            this.Load += new System.EventHandler(this.materiaCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}