using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class alunoCad : Form
    {
        public alunoCad()
        {
            InitializeComponent();
        }
        List<Aluno> alunos = new List<Aluno>();
        private bool ValidarCampoString(string campoValidar, string nomeCampo)
        {
            if (campoValidar == "")
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Etec de Taboão da Serra");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarCampoNum(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!", "Etec de Taboão da Serra");
                return false;
            }
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtBairro.Clear();
            txtCel.Clear();
            txtCep.Clear();
            txtCid.Clear();
            txtCompl.Clear();
            txtCpf.Clear();
            txtDn.Clear();
            txtNum.Clear();
            txtTel.Clear();
            txtLogra.Clear();
            cboEst.Text = "";
            cboSexo.Text = "";
        }

        public void Cadastrar()
        {
            Aluno aluno = new Aluno();
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            aluno.nome = txtNome.Text;
            if (ValidarCampoString(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            aluno.número = txtNum.Text;
            aluno.sexo = cboSexo.Text;
            aluno.estado = cboEst.Text;
            aluno.celular = txtCel.Text;
            aluno.telefone = txtTel.Text;
            aluno.bairro = txtBairro.Text;
            aluno.logradouro = txtLogra.Text;
            aluno.complemento = txtCompl.Text;
            aluno.CPF = txtCpf.Text;
            aluno.dataDeNascimento = txtDn.Text;
            aluno.cidade = txtCid.Text;
            alunos.Add(aluno);
            dgvAlunos.DataSource = alunos.ToList();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
            Limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            
        }
    }
}
