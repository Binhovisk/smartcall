using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plucas
{
    public partial class SmartCall : Form
    {
        public SmartCall()
        {
            InitializeComponent();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefone: (19)9999-9999", "SmartCall", MessageBoxButtons.OK);
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
