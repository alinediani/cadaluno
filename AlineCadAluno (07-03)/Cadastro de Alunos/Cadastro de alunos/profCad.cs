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
    public partial class profCad : Form
    {
        public profCad()
        {
            InitializeComponent();
        }
        List<Professor> professores = new List<Professor>();

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
            Professor professor = new Professor();
            professor.id = dgvProfs.RowCount;
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            professor.nome = txtNome.Text;
            if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
            {
                cboSexo.Focus();
                return;
            }
            professor.sexo = cboSexo.Text;
            if (ValidarCampoString(txtCpf.Text, "CPF") == false)
            {
                txtCpf.Clear();
                txtCpf.Focus();
                return;
            }
            professor.cpf = txtCpf.Text;
            if (ValidarCampoString(txtDn.Text, "Data de Nascimento") == false)
            {
                txtDn.Clear();
                txtDn.Focus();
                return;
            }
            professor.dn = txtDn.Text;
            if (ValidarCampoString(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            professor.tl = txtTel.Text;
            if (ValidarCampoString(txtCel.Text, "Celular") == false)
            {
                txtCel.Clear();
                txtCel.Focus();
                return;
            }
            professor.cel = txtCel.Text;
            if (ValidarCampoString(cboEst.Text, "Estado") == false)
            {
                cboEst.Focus();
                return;
            }
            professor.est = cboEst.Text;
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            professor.cid = txtCid.Text;
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            professor.bairro = txtBairro.Text;
            if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
            {
                txtLogra.Clear();
                txtLogra.Focus();
                return;
            }
            professor.logra = txtLogra.Text;
            if (ValidarCampoNum(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            professor.num = int.Parse(txtNum.Text);
            if (ValidarCampoString(txtCep.Text, "CEP") == false)
            {
                txtCep.Clear();
                txtCep.Focus();
                return;
            }
            professor.cep = txtCep.Text;
            if (txtCompl.Text != "")
            {
                professor.comp = txtCompl.Text;
            }
            else
            {
                professor.comp = "null";
            }
            professor.dtAlt = "0";
            professor.ativo = 1;
            professores.Add(professor);
            dgvProfs.DataSource = professores.ToList();
            LimparCampos();

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
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
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void profCad_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvProfs.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvProfs.Rows[i].Cells.Count; a++)
                {
                    if (dgvProfs.Rows[i].Selected == true || dgvProfs.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvProfs.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvProfs.Rows[i].Cells.Count; b++)
                        {
                            dgvProfs.Rows[i].Cells[b].Value = null;
                        }
                        dgvProfs.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvProfs.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvProfs.Rows[i].Cells.Count; a++)
                {
                    if (dgvProfs.Rows[i].Selected == true || dgvProfs.Rows[i].Cells[a].Selected == true)
                    {
                        dgvProfs.Rows[i].Cells[15].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvProfs.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvProfs.Rows[i].Cells.Count; a++)
                {
                    if (dgvProfs.Rows[i].Selected == true || dgvProfs.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
                        {
                            cboSexo.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[2].Value = cboSexo.Text;
                        if (ValidarCampoString(txtCpf.Text, "CPF") == false)
                        {
                            txtCpf.Clear();
                            txtCpf.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[3].Value = txtCpf.Text;
                        if (ValidarCampoString(txtDn.Text, "Data de Nascimento") == false)
                        {
                            txtDn.Clear();
                            txtDn.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[4].Value = txtDn.Text;
                        if (ValidarCampoString(txtTel.Text, "Telefone") == false)
                        {
                            txtTel.Clear();
                            txtTel.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[5].Value = txtTel.Text;
                        if (ValidarCampoString(txtCel.Text, "Celular") == false)
                        {
                            txtCel.Clear();
                            txtCel.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[6].Value = txtCel.Text;
                        if (ValidarCampoString(cboEst.Text, "Estado") == false)
                        {
                            cboEst.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[7].Value = cboEst.Text;
                        if (ValidarCampoString(txtCid.Text, "Cidade") == false)
                        {
                            txtCid.Clear();
                            txtCid.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[8].Value = txtCid.Text;
                        if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
                        {
                            txtBairro.Clear();
                            txtBairro.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[9].Value = txtBairro.Text;
                        if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
                        {
                            txtLogra.Clear();
                            txtLogra.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[10].Value = txtLogra.Text;
                        if (ValidarCampoNum(txtNum.Text, "Número") == false)
                        {
                            txtNum.Clear();
                            txtNum.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[11].Value = int.Parse(txtNum.Text);
                        if (ValidarCampoString(txtCep.Text, "CEP") == false)
                        {
                            txtCep.Clear();
                            txtCep.Focus();
                            return;
                        }
                        dgvProfs.Rows[i].Cells[12].Value = txtCep.Text;
                        if (txtCompl.Text != "")
                        {
                            dgvProfs.Rows[i].Cells[13].Value = txtCompl.Text;
                        }
                        else
                        {
                            dgvProfs.Rows[i].Cells[13].Value = "null";
                        }
                        dgvProfs.Rows[i].Cells[14].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void profCad_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvProfs.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvProfs.Rows[i].Cells.Count; a++)
                {
                    if (dgvProfs.Rows[i].Selected == true || dgvProfs.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvProfs.Rows[i].Cells[1].Value.ToString();
                        cboSexo.Text = dgvProfs.Rows[i].Cells[2].Value.ToString();
                        txtCpf.Text = dgvProfs.Rows[i].Cells[3].Value.ToString();
                        txtDn.Text = dgvProfs.Rows[i].Cells[4].Value.ToString();
                        txtTel.Text = dgvProfs.Rows[i].Cells[5].Value.ToString();
                        txtCel.Text = dgvProfs.Rows[i].Cells[6].Value.ToString();
                        cboEst.Text = dgvProfs.Rows[i].Cells[7].Value.ToString();
                        txtCid.Text = dgvProfs.Rows[i].Cells[8].Value.ToString();
                        txtBairro.Text = dgvProfs.Rows[i].Cells[9].Value.ToString();
                        txtLogra.Text = dgvProfs.Rows[i].Cells[10].Value.ToString();
                        txtNum.Text = dgvProfs.Rows[i].Cells[11].Value.ToString();
                        txtCep.Text = dgvProfs.Rows[i].Cells[12].Value.ToString();
                        txtCompl.Text = dgvProfs.Rows[i].Cells[13].Value.ToString();
                    }

                }
            }
        }
    }
}
