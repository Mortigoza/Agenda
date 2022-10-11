using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarListas();
            LimpiarControles();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmDatosAgendados datos = new frmDatosAgendados();
            datos.ShowDialog();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            
            


        }

        public void CargarListas()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Los campos Nombre y Teléfono se deben llenar obligatoriamente");
            }
            else if (txtDireccion.Text.Length > 0 || txtApellido.Text.Length > 0)
            {
                clsAgenda completa = new clsAgenda(txtNombre.Text, txtTelefono.Text, txtApellido.Text, txtDireccion.Text);
                clsListaAgendaCompleta.agendaCompleta.Add(completa);
                
            }
            else
            {
                clsAgenda simple = new clsAgenda(txtNombre.Text, txtTelefono.Text);
                clsListaAgendaSimple.agendaSimple.Add(simple);
                
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
        }
    }
}
