using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }
      
        private void btn_cad_funcionario_Click_1(object sender, EventArgs e)
        {
            frm_Funcionario frm = new frm_Funcionario();
            frm.Show();
        }

        private void btn_cad_Obra_Click(object sender, EventArgs e)
        {
            frm_Obras frm = new frm_Obras();
            frm.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Funcionario frm = new frm_Funcionario();
            frm.Show();
        }

        private void obraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Obras frm = new frm_Obras();
            frm.Show();
        }
    }
}
