using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen2_AndreaAlvarez.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void TiposToolStripButton_Click(object sender, EventArgs e)
        {
            TiposView vista = new TiposView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void EstadoToolStripButton_Click(object sender, EventArgs e)
        {
           EstadoView vista = new EstadoView();
            vista.MdiParent = this;
            vista.Show();
        }

        private void TicketsToolStripButton_Click(object sender, EventArgs e)
        {
            Tickets vista = new Tickets();
            vista.MdiParent = this;
            vista.Show();
        }

        private void DetalleToolStripButton_Click(object sender, EventArgs e)
        {
            DetalleView vista = new DetalleView();
            vista.MdiParent = this;
            vista.Show();
        }
    }
}
