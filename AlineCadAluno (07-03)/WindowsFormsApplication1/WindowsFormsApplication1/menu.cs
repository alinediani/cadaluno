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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alunoCad aluninho = new alunoCad();
            aluninho.MdiParent = this;
            aluninho.Show();
        }
    }
}
