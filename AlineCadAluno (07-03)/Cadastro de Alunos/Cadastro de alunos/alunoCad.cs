using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_alunos
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

        private void Cadastrar()
        {
            Aluno aluno = new Aluno();

            aluno.id = dgvAlunos.RowCount;
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            aluno.nome = txtNome.Text;
            if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
            {
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
            aluno.cpf = txtCpf.Text;
            if (ValidarCampoString(txtDn.Text, "Data de Nascimento") == false)
            {
                txtDn.Clear();
                txtDn.Focus();
                return;
            }
            aluno.dn = txtDn.Text;
            if (ValidarCampoString(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            aluno.tl = txtTel.Text;
            if (ValidarCampoString(txtCel.Text, "Celular") == false)
            {
                txtCel.Clear();
                txtCel.Focus();
                return;
            }
            aluno.cel = txtCel.Text;
            if (ValidarCampoString(cboEst.Text, "Estado") == false)
            {
                cboEst.Focus();
                return;
            }
            aluno.est = cboEst.Text;
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            aluno.cid = txtCid.Text;
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
            aluno.logra = txtLogra.Text;
            if (ValidarCampoNum(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            aluno.num = int.Parse(txtNum.Text);
            if (ValidarCampoString(txtCep.Text, "CEP") == false)
            {
                txtCep.Clear();
                txtCep.Focus();
                return;
            }
            aluno.cep = txtCep.Text;
            if(txtCompl.Text != "")
            {
                aluno.comp = txtCompl.Text;
            }
            else
            {
                aluno.comp = "null";
            }
            aluno.dtAlt = "0";
            aluno.ativo = 1;
            alunos.Add(aluno);
            dgvAlunos.DataSource = alunos.ToList();
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtDn.Clear();
            txtTel.Clear();
            txtCel.Clear();
            txtCid.Clear();
            txtBairro.Clear();
            txtLogra.Clear();
            txtNum.Clear();
            txtCep.Clear();
            txtCompl.Clear();
            cboEst.ResetText();
            cboSexo.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void alunoCad_Load(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvAlunos.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvAlunos.Rows[i].Cells.Count; b++)
                        {
                            dgvAlunos.Rows[i].Cells[b].Value = null;
                        }
                        dgvAlunos.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        dgvAlunos.Rows[i].Cells[15].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
                        {
                            cboSexo.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[2].Value = cboSexo.Text;
                        if (ValidarCampoString(txtCpf.Text, "CPF") == false)
                        {
                            txtCpf.Clear();
                            txtCpf.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[3].Value = txtCpf.Text;
                        if (ValidarCampoString(txtDn.Text, "Data de Nascimento") == false)
                        {
                            txtDn.Clear();
                            txtDn.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[4].Value = txtDn.Text;
                        if (ValidarCampoString(txtTel.Text, "Telefone") == false)
                        {
                            txtTel.Clear();
                            txtTel.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[5].Value = txtTel.Text;
                        if (ValidarCampoString(txtCel.Text, "Celular") == false)
                        {
                            txtCel.Clear();
                            txtCel.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[6].Value = txtCel.Text;
                        if (ValidarCampoString(cboEst.Text, "Estado") == false)
                        {
                            cboEst.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[7].Value = cboEst.Text;
                        if (ValidarCampoString(txtCid.Text, "Cidade") == false)
                        {
                            txtCid.Clear();
                            txtCid.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[8].Value = txtCid.Text;
                        if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
                        {
                            txtBairro.Clear();
                            txtBairro.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[9].Value = txtBairro.Text;
                        if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
                        {
                            txtLogra.Clear();
                            txtLogra.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[10].Value = txtLogra.Text;
                        if (ValidarCampoNum(txtNum.Text, "Número") == false)
                        {
                            txtNum.Clear();
                            txtNum.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[11].Value = int.Parse(txtNum.Text);
                        if (ValidarCampoString(txtCep.Text, "CEP") == false)
                        {
                            txtCep.Clear();
                            txtCep.Focus();
                            return;
                        }
                        dgvAlunos.Rows[i].Cells[12].Value = txtCep.Text;
                        if (txtCompl.Text != "")
                        {
                            dgvAlunos.Rows[i].Cells[13].Value = txtCompl.Text;
                        }
                        else
                        {
                            dgvAlunos.Rows[i].Cells[13].Value = "null";
                        }
                        
                        dgvAlunos.Rows[i].Cells[14].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void alunoCad_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvAlunos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvAlunos.Rows[i].Cells.Count; a++)
                {
                    if (dgvAlunos.Rows[i].Selected == true || dgvAlunos.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvAlunos.Rows[i].Cells[1].Value.ToString();
                        cboSexo.Text = dgvAlunos.Rows[i].Cells[2].Value.ToString();
                        txtCpf.Text = dgvAlunos.Rows[i].Cells[3].Value.ToString();
                        txtDn.Text = dgvAlunos.Rows[i].Cells[4].Value.ToString();
                        txtTel.Text = dgvAlunos.Rows[i].Cells[5].Value.ToString();
                        txtCel.Text = dgvAlunos.Rows[i].Cells[6].Value.ToString();
                        cboEst.Text = dgvAlunos.Rows[i].Cells[7].Value.ToString();
                        txtCid.Text = dgvAlunos.Rows[i].Cells[8].Value.ToString();
                        txtBairro.Text = dgvAlunos.Rows[i].Cells[9].Value.ToString();
                        txtLogra.Text = dgvAlunos.Rows[i].Cells[10].Value.ToString();
                        txtNum.Text = dgvAlunos.Rows[i].Cells[11].Value.ToString();
                        txtCep.Text = dgvAlunos.Rows[i].Cells[12].Value.ToString();
                        txtCompl.Text = dgvAlunos.Rows[i].Cells[13].Value.ToString();
                    }

                }
            }
        }
    }
}
