using RegistroBiblia.UI.Consultas;
using RegistroBiblia.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace RegistroBiblia
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibros c = new rLibros();
            
            c.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cconsultas c = new Cconsultas();
            c.MdiParent = this;
            c.Show();
        }

        private void libroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rLibros c = new rLibros();
            c.MdiParent = this;
            c.Show();
        }
    }
}
