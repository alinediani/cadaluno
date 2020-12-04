namespace Cadastro_de_alunos
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Aluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Escola = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Materia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Periodo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_Professor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro_Aluno,
            this.menuCadastro_Escola,
            this.menuCadastro_Materia,
            this.menuCadastro_Periodo,
            this.menuCadastro_Professor});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(86, 24);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuCadastro_Aluno
            // 
            this.menuCadastro_Aluno.Name = "menuCadastro_Aluno";
            this.menuCadastro_Aluno.Size = new System.Drawing.Size(145, 26);
            this.menuCadastro_Aluno.Text = "Aluno";
            this.menuCadastro_Aluno.Click += new System.EventHandler(this.menuCadastro_Aluno_Click);
            // 
            // menuCadastro_Escola
            // 
            this.menuCadastro_Escola.Name = "menuCadastro_Escola";
            this.menuCadastro_Escola.Size = new System.Drawing.Size(145, 26);
            this.menuCadastro_Escola.Text = "Escola";
            this.menuCadastro_Escola.Click += new System.EventHandler(this.menuCadastro_Escola_Click);
            // 
            // menuCadastro_Materia
            // 
            this.menuCadastro_Materia.Name = "menuCadastro_Materia";
            this.menuCadastro_Materia.Size = new System.Drawing.Size(145, 26);
            this.menuCadastro_Materia.Text = "Matéria";
            this.menuCadastro_Materia.Click += new System.EventHandler(this.menuCadastro_Materia_Click);
            // 
            // menuCadastro_Periodo
            // 
            this.menuCadastro_Periodo.Name = "menuCadastro_Periodo";
            this.menuCadastro_Periodo.Size = new System.Drawing.Size(145, 26);
            this.menuCadastro_Periodo.Text = "Período";
            this.menuCadastro_Periodo.Click += new System.EventHandler(this.menuCadastro_Periodo_Click);
            // 
            // menuCadastro_Professor
            // 
            this.menuCadastro_Professor.Name = "menuCadastro_Professor";
            this.menuCadastro_Professor.Size = new System.Drawing.Size(145, 26);
            this.menuCadastro_Professor.Text = "Professor";
            this.menuCadastro_Professor.Click += new System.EventHandler(this.menuCadastro_Professor_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Aluno;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Escola;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Materia;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Periodo;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_Professor;
    }
}