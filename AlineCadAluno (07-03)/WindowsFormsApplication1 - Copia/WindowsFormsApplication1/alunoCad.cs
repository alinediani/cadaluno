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
            if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
            {
                cboSexo.Text = "";
                cboSexo.Focus();
                return;
            }
            aluno.sexo = cboSexo.Text;
            if (ValidarCampoString(txtCpf.Text, "CPF") == false)
            {
                txtCpf.Clear();
                txtCpf.Focus();
                return;
            }
            aluno.CPF = txtCpf.Text;
            if (ValidarCampoString(txtDn.Text, "Data de Nascimento") == false)
            {
                txtDn.Clear();
                txtDn.Focus();
                return;
            }
            aluno.dataDeNascimento = txtDn.Text;
            if (ValidarCampoString(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            aluno.telefone = txtTel.Text;
            if (ValidarCampoString(txtCel.Text, "Celular") == false)
            {
                txtCel.Clear();
                txtCel.Focus();
                return;
            }
            aluno.celular = txtCel.Text;
            if (ValidarCampoString(cboEst.Text, "Estado") == false)
            {
                cboEst.Text = "";
                cboEst.Focus();
                return;
            }
            aluno.estado = cboEst.Text;
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            aluno.cidade = txtCid.Text;
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            aluno.bairro = txtBairro.Text;
            if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
            {
                txtLogra.Clear();
                txtLogra.Focus();
                return;
            }
            aluno.logradouro = txtLogra.Text;
            if (ValidarCampoString(txtCep.Text, "CEP") == false)
            {
                txtCep.Clear();
                txtCep.Focus();
                return;
            }
            aluno.cep = txtCep.Text;
            if (ValidarCampoString(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            aluno.número = txtNum.Text;
            if (ValidarCampoString(txtCompl.Text, "Complemento") == false)
            {
                txtCompl.Clear();
                txtCompl.Focus();
                return;
            }
            aluno.complemento = txtCompl.Text;
            alunos.Add(aluno);
            dgvAlunos.DataSource = alunos.ToList();
            Limpar();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            
        }
    }
}
