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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuCadastro_Aluno_Click(object sender, EventArgs e)
        {
            alunoCad aluno = new alunoCad();
            aluno.MdiParent = this;
            aluno.Show();
        }

        private void menuCadastro_Escola_Click(object sender, EventArgs e)
        {
            escolaCad escola = new escolaCad();
            escola.MdiParent = this;
            escola.Show();
        }

        private void menuCadastro_Materia_Click(object sender, EventArgs e)
        {
            materiaCad materia = new materiaCad();
            materia.MdiParent = this;
            materia.Show();
        }

        private void menuCadastro_Periodo_Click(object sender, EventArgs e)
        {
            periodoCad periodo = new periodoCad();
            periodo.MdiParent = this;
            periodo.Show();
        }

        private void menuCadastro_Professor_Click(object sender, EventArgs e)
        {
            profCad prof = new profCad();
            prof.MdiParent = this;
            prof.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }
    }
}
