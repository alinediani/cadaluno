namespace WindowsFormsApplication1
{
    partial class alunoCad
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
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cboEst = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(210, 322);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 59;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(166, 351);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 62;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // cboEst
            // 
            this.cboEst.FormattingEnabled = true;
            this.cboEst.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEst.Location = new System.Drawing.Point(182, 64);
            this.cboEst.Name = "cboEst";
            this.cboEst.Size = new System.Drawing.Size(140, 21);
            this.cboEst.TabIndex = 46;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(182, 242);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(82, 20);
            this.txtCep.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "CEP:";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(349, 12);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(424, 362);
            this.dgvAlunos.TabIndex = 66;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(128, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 58;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(48, 322);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 56;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cboSexo.Location = new System.Drawing.Point(22, 108);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(140, 21);
            this.cboSexo.TabIndex = 38;
            // 
            // txtCompl
            // 
            this.txtCompl.Location = new System.Drawing.Point(182, 288);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(140, 20);
            this.txtCompl.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Complemento:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(269, 242);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(54, 20);
            this.txtNum.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Número";
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(182, 193);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(140, 20);
            this.txtLogra.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Logradouro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(182, 152);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(140, 20);
            this.txtBairro.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Bairro:";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(182, 108);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(140, 20);
            this.txtCid.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Cidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(183, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Estado:";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(22, 288);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(140, 20);
            this.txtCel.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Celular:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(22, 242);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(140, 20);
            this.txtTel.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Telefone:";
            // 
            // txtDn
            // 
            this.txtDn.Location = new System.Drawing.Point(22, 193);
            this.txtDn.Name = "txtDn";
            this.txtDn.Size = new System.Drawing.Size(140, 20);
            this.txtDn.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Data de Nascimento:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(22, 152);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(140, 20);
            this.txtCpf.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Sexo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 20);
            this.txtNome.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cadastro de Alunos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 675);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cboEst);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtCompl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLogra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboEst;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

