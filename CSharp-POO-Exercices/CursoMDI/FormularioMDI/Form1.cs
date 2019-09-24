using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void Form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.Blue;
                    break;
                }
            }
        }
    }
}
