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
    public partial class frmDatosAgendados : Form
    {
        public frmDatosAgendados()
        {
            InitializeComponent();
        }

        private void DatosAgendados_Load(object sender, EventArgs e)
        {
            /*if (rbtAgendaSimple.Checked)
            {
                dtgResultado.DataSource = null;
                dtgResultado.DataSource = clsListaAgendaSimple.agendaSimple;
            }
            else
            {
                dtgResultado.DataSource = null;
                dtgResultado.DataSource = clsListaAgendaCompleta.agendaCompleta;
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rbtAgendaSimple_CheckedChanged(object sender, EventArgs e)
        {
            dtgResultado.DataSource = null;
            dtgResultado.DataSource = clsListaAgendaSimple.agendaSimple;
        }

        private void rbtAgendaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            dtgResultado.DataSource = null;
            dtgResultado.DataSource = clsListaAgendaCompleta.agendaCompleta;
        }
    }
}
