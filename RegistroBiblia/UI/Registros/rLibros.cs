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

namespace RegistroBiblia.UI.Registros
{
    public partial class rLibros : Form
    {
        public rLibros()
        {
            InitializeComponent();
        }
        private void inactivo()
        {
            Guardar_button.Enabled = false;
            Descripcion_textBox.Enabled = false;
            Siglas_textBox.Enabled = false;
            TipId_comboBox.Enabled = false;
        }
        private void activos()
        {
            Guardar_button.Enabled = true;
            Descripcion_textBox.Enabled = true;
            Siglas_textBox.Enabled = true;
            TipId_comboBox.Enabled = true;
        }

        private void rLibros_Load(object sender, EventArgs e)
        {
            inactivo();
        }
        private void Limpiar()
        {
            LibroId_numericUpDown.Value = 0;
             Descripcion_textBox.Text = string.Empty;
             Siglas_textBox.Text = string.Empty;
             TipId_comboBox.Text = string.Empty;
        }
        // aqui se crea el boton nuevo
        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
            activos();
            Nuevo_button.Enabled = false;
            Eliminar_button.Enabled = false;
        }

        private Libros LlenaClase()
        {
            Libros libros = new Libros();
            libros.LibroId = Convert.ToInt32(LibroId_numericUpDown.Value);
            libros.Descripcion = Descripcion_textBox.Text;
            libros.Siglas = Siglas_textBox.Text;
            libros.TipoId = TipId_comboBox.Text;
            return libros;
        }
        private Libros LlenaCampo(Libros libros)
        {
           // Libros libros = new Libros();
            libros.LibroId = Convert.ToInt32(LibroId_numericUpDown.Value);
            Descripcion_textBox.Text= libros.Descripcion ;
            Siglas_textBox.Text= libros.Siglas ;
            TipId_comboBox.Text=libros.TipoId ;
            return libros;
        }

        private bool validar()
        {
            bool TieneErrores = false;
            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
                MessageBox.Show("Debe Llenar el campo");
                TieneErrores = true;
            }
            return TieneErrores;
        }
        private bool GuardarValidar()
        {
            bool paso = true;
            if ( string.IsNullOrWhiteSpace(Descripcion_textBox.Text) ||  string.IsNullOrWhiteSpace(Siglas_textBox.Text) ||string.IsNullOrWhiteSpace(TipId_comboBox.Text))
            {

                if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
                {
                    SuperErrorProvider.SetError(Descripcion_textBox, "ingrese Descripcion");
                    Descripcion_textBox.Focus();
                }
                if( string.IsNullOrWhiteSpace(Siglas_textBox.Text))
                {
                    SuperErrorProvider.SetError( Siglas_textBox, "ingrese la siglas");
                    Siglas_textBox.Focus();
                }
                if( string.IsNullOrWhiteSpace(TipId_comboBox.Text))
                {
                    SuperErrorProvider.SetError(TipId_comboBox, "ingrese el tipo de libro");
                    TipId_comboBox.Focus();
                }
                paso = false;
            }
            return paso;
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id = (int)LibroId_numericUpDown.Value;
            //int.TryParse(LibroId_numericUpDown.Text, out  id);
            Libros libros = LibrosBLL.Buscar(id);
            Libros libros_guardar = LlenaClase();
           // bool paso = false;
          //  Libros libro = new Libros();
            if (libros == null)
            {
                if (GuardarValidar())
                {
                    if (LibrosBLL.Guardar(libros_guardar))
                    {
                       MessageBox.Show("libro guardado");
                        Limpiar();
                        inactivo();
                        Nuevo_button.Enabled = true;
                        Eliminar_button.Enabled = true;

                    }
                    
                    else
                    MessageBox.Show("libro no guadado");

                }
            }
            else
            {
                if (GuardarValidar())
                {
                    if (LibrosBLL.Modificar(libros_guardar))
                        MessageBox.Show("libro modificada");
                    else
                        MessageBox.Show("libro no modificada");
                }
            }  
              
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            int.TryParse(LibroId_numericUpDown.Text, out id);

            Libros libros = BLL.LibrosBLL.Buscar(id);

            if (libros != null)
            {
                BLL.LibrosBLL.Eliminar(id);
                MessageBox.Show("libro eliminado");
                Limpiar();
                inactivo();
                Nuevo_button.Enabled = true;
                Eliminar_button.Enabled = true;
            }
            else
            {
            
                MessageBox.Show("nose puede eliminar un libro que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nuevo_button.PerformClick();
                inactivo();
                Nuevo_button.Enabled = true;
                Eliminar_button.Enabled = true;
            }
          
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            Libros libros = new Libros();
             int.TryParse(LibroId_numericUpDown.Text, out id);
           libros = LibrosBLL.Buscar(id);
            if(libros != null)
            {
                MessageBox.Show("libro encontrado");
                Eliminar_button.Enabled = true;
                Guardar_button.Enabled = false;
                Nuevo_button.Enabled = true;
               LlenaCampo(libros);
            }
            else
            {
                MessageBox.Show("libro no encontrado");
                inactivo();
               // Nuevo_button.PerformClick();
                Nuevo_button.Enabled = true;
            }


        }

     
     
    }
}
