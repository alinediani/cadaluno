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
    public partial class periodoCad : Form
    {
        public periodoCad()
        {
            InitializeComponent();
        }
        List<Periodo> periodos = new List<Periodo>();

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
            Periodo periodo = new Periodo();
            periodo.id = dgvPeriodos.RowCount;
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            periodo.nome = txtNome.Text;
            if (ValidarCampoString(txtHrIni.Text, "Hora(Início)") == false)
            {
                txtHrIni.Clear();
                txtHrIni.Focus();
                return;
            }
            periodo.hri = txtHrIni.Text;
            if (ValidarCampoString(txtHrTer.Text, "Hora(Término)") == false)
            {
                txtHrTer.Clear();
                txtHrTer.Focus();
                return;
            }
            periodo.hrt = txtHrTer.Text;
            periodo.dtAlt = "0";
            periodo.ativo = 1;
            periodos.Add(periodo);
            dgvPeriodos.DataSource = periodos.ToList();
            LimparCampos();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void LimparCampos()
        {
            txtHrIni.Clear();
            txtHrTer.Clear();
            txtNome.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void periodoCad_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        string id = dgvPeriodos.Rows[i].Cells[0].Value.ToString();
                        for (int b = 0; b < dgvPeriodos.Rows[i].Cells.Count; b++)
                        {
                            dgvPeriodos.Rows[i].Cells[b].Value = null;
                        }
                        dgvPeriodos.Rows[i].Cells[0].Value = int.Parse(id);
                    }

                }

            }
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        dgvPeriodos.Rows[i].Cells[5].Value = 0;
                    }

                }

            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        if (ValidarCampoString(txtNome.Text, "Nome") == false)
                        {
                            txtNome.Clear();
                            txtNome.Focus();
                            return;
                        }
                        dgvPeriodos.Rows[i].Cells[1].Value = txtNome.Text;
                        if (ValidarCampoString(txtHrIni.Text, "Hora(Início)") == false)
                        {
                            txtHrIni.Clear();
                            txtHrIni.Focus();
                            return;
                        }
                        dgvPeriodos.Rows[i].Cells[2].Value = txtHrIni.Text;
                        if (ValidarCampoString(txtHrTer.Text, "Hora(Término)") == false)
                        {
                            txtHrTer.Clear();
                            txtHrTer.Focus();
                            return;
                        }
                        dgvPeriodos.Rows[i].Cells[3].Value = txtHrTer.Text;
                        dgvPeriodos.Rows[i].Cells[4].Value = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                    }

                }
            }
        }

        private void periodoCad_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cont = dgvPeriodos.RowCount;
            for (int i = 0; i < cont; i++)
            {
                for (int a = 0; a < dgvPeriodos.Rows[i].Cells.Count; a++)
                {
                    if (dgvPeriodos.Rows[i].Selected == true || dgvPeriodos.Rows[i].Cells[a].Selected == true)
                    {
                        txtNome.Text = dgvPeriodos.Rows[i].Cells[1].Value.ToString();
                        txtHrIni.Text = dgvPeriodos.Rows[i].Cells[2].Value.ToString();
                        txtHrTer.Text = dgvPeriodos.Rows[i].Cells[3].Value.ToString();
                    }

                }
            }
        }
    }
}
