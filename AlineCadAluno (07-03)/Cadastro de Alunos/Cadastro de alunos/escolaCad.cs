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
    public partial class escolaCad : Form
    {
        public escolaCad()
        {
            InitializeComponent();
        }
        List<Escola> escolas = new List<Escola>();

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
            Escola escola = new Escola();
            escola.id = dgvEscolas.RowCount;
            if(ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            escola.nome = txtNome.Text;
            if (ValidarCampoString(txtCnpj.Text, "CNPJ") == false)
            {
                txtCnpj.Clear();
                txtCnpj.Focus();
                return;
            }
            escola.cnpj = txtCnpj.Text;
            if (ValidarCampoString(txtTel.Text, "Telefone") == false)
            {
                txtTel.Clear();
                txtTel.Focus();
                return;
            }
            escola.tl = txtTel.Text;
            if (txtTel2.Text != "")
            {
                escola.tl2 = txtCompl.Text;
            }
            else
            {
                escola.tl2 = "null";
            }
            if (ValidarCampoString(cboEst.Text, "Estado") == false)
            {
                cboEst.Focus();
                return;
            }
            escola.est = cboEst.Text;
            if (ValidarCampoString(txtCid.Text, "Cidade") == false)
            {
                txtCid.Clear();
                txtCid.Focus();
                return;
            }
            escola.cid = txtCid.Text;
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            escola.bairro = txtBairro.Text;
            if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
            {
                txtLogra.Clear();
                txtLogra.Focus();
                return;
            }
            escola.logra = txtLogra.Text;
            if (ValidarCampoNum(txtNum.Text, "Número") == false)
            {
                txtNum.Clear();
                txtNum.Focus();
                return;
            }
            escola.num = int.Parse(txtNum.Text);
            if (ValidarCampoString(txtCep.Text, "CEP") == false)
            {
                txtCep.Clear();
                txtCep.Focus();
                return;
            }
            escola.cep = txtCep.Text;
            if (txtCompl.Text != "")
            {
                escola.comp = txtCompl.Text;
            }
            else
            {
                escola.comp = "null";
            }
            escola.dtAlt = "0";
            escola.ativo = 1;
            escolas.Add(escola);
            dgvEscolas.DataSource = escolas.ToList();
            LimparCampos();
        }

        private void btnCad_Click(object sender, EventArgs e) //btnCadastrar
        {
            Cadastrar();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCnpj.Clear();
            txtTel.Clear();
            txtTel2.Clear();
            txtCid.Clear();
            txtBairro.Clear();
            txtLogra.Clear();
            txtNum.Clear();
            txtCep.Clear();
            txtCompl.Clear();
            cboEst.ResetText();
        }

        private void btnLimpar_Click(object sender, EventArgs e) //btnLimpar
        {
            LimparCampos();
        }

        private void escolaCad_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvEscolas.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvEscolas.Rows[i].Cells.Count; b++)
                        {
                            dgvEscolas.Rows[i].Cells[b].Value = null;
                        }
                        dgvEscolas.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        dgvEscolas.Rows[i].Cells[13].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(txtCnpj.Text, "CNPJ") == false)
                        {
                            txtCnpj.Clear();
                            txtCnpj.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[2].Value = txtCnpj.Text;
                        if (ValidarCampoString(txtTel.Text, "Telefone") == false)
                        {
                            txtTel.Clear();
                            txtTel.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[3].Value = txtTel.Text;
                        if (txtTel2.Text != "")
                        {
                            dgvEscolas.Rows[i].Cells[4].Value = txtTel2.Text;
                        }
                        else
                        {
                            dgvEscolas.Rows[i].Cells[4].Value = "null";
                        }
                        if (ValidarCampoString(cboEst.Text, "Estado") == false)
                        {
                            cboEst.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[5].Value = cboEst.Text;
                        if (ValidarCampoString(txtCid.Text, "Cidade") == false)
                        {
                            txtCid.Clear();
                            txtCid.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[6].Value = txtCid.Text;
                        if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
                        {
                            txtBairro.Clear();
                            txtBairro.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[7].Value = txtBairro.Text;
                        if (ValidarCampoString(txtLogra.Text, "Logradouro") == false)
                        {
                            txtLogra.Clear();
                            txtLogra.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[8].Value = txtLogra.Text;
                        if (ValidarCampoNum(txtNum.Text, "Número") == false)
                        {
                            txtNum.Clear();
                            txtNum.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[9].Value = int.Parse(txtNum.Text);
                        if (ValidarCampoString(txtCep.Text, "CEP") == false)
                        {
                            txtCep.Clear();
                            txtCep.Focus();
                            return;
                        }
                        dgvEscolas.Rows[i].Cells[10].Value = txtCep.Text;
                        if (txtCompl.Text != "")
                        {
                            dgvEscolas.Rows[i].Cells[11].Value = txtCompl.Text;
                        }
                        else
                        {
                            dgvEscolas.Rows[i].Cells[11].Value = "null";
                        }
                        dgvEscolas.Rows[i].Cells[12].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void escolaCad_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvEscolas.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvEscolas.Rows[i].Cells.Count; a++)
                {
                    if (dgvEscolas.Rows[i].Selected == true || dgvEscolas.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvEscolas.Rows[i].Cells[1].Value.ToString();
                        txtCnpj.Text = dgvEscolas.Rows[i].Cells[2].Value.ToString();
                        txtTel.Text = dgvEscolas.Rows[i].Cells[3].Value.ToString();
                        txtTel2.Text = dgvEscolas.Rows[i].Cells[4].Value.ToString();
                        cboEst.Text = dgvEscolas.Rows[i].Cells[5].Value.ToString();
                        txtCid.Text = dgvEscolas.Rows[i].Cells[6].Value.ToString();
                        txtBairro.Text = dgvEscolas.Rows[i].Cells[7].Value.ToString();
                        txtLogra.Text = dgvEscolas.Rows[i].Cells[8].Value.ToString();
                        txtNum.Text = dgvEscolas.Rows[i].Cells[9].Value.ToString();
                        txtCep.Text = dgvEscolas.Rows[i].Cells[10].Value.ToString();
                        txtCompl.Text = dgvEscolas.Rows[i].Cells[11].Value.ToString();

                    }

                }
            }
        }
    }
}
