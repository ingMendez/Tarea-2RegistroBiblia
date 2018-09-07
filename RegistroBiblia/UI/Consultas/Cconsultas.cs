using RegistroBiblia.BLL;
using RegistroLibroBiblia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroBiblia.UI.Consultas
{
    public partial class Cconsultas : Form
    {
        public Cconsultas()
        {
            InitializeComponent();
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            var listado = new List<Libros>();
            if (CriterioTextTbox.Text.Trim().Length > 0)
            {
                switch (FitarComboBox.SelectedIndex)
                {
                    case 0: // todo
                        listado = LibrosBLL.GetList(p => true);
                        break;
                    case 1://Id
                        int id = Convert.ToInt32(CriterioTextTbox.Text);
                        break;
                    case 2: // descripcion
                        listado = LibrosBLL.GetList(p => p.Descripcion.Contains(CriterioTextTbox.Text));
                        break;
                    case 3:
                        listado = LibrosBLL.GetList(p => p.TipoId.Contains(CriterioTextTbox.Text));
                        break;
                    
                }

            }
        }

        private void NombreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
