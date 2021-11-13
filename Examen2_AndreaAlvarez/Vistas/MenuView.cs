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

        TiposView vistaTipos;
        private void TiposToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTipos == null)
            {
                vistaTipos = new TiposView();
                vistaTipos.MdiParent = this;
                vistaTipos.FormClosed += vistaTipos_FormClosed;
                vistaTipos.Show();
            }
            else
            {
                vistaTipos.Activate();
            }
           
        }
        private void vistaTipos_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTipos = null;
           
        }



        EstadoView vistaEstado;
        private void EstadoToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaEstado == null)
            {
                vistaEstado = new EstadoView();
                vistaEstado.MdiParent = this;
                vistaEstado.FormClosed += vistaEstado_FormClosed; 
                vistaEstado.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
            
        }
        private void vistaEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            vistaEstado = null;
            
        }


        TicketsView vistaTicket; 
        private void TicketsToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTicket == null)
            {
                vistaTicket = new TicketsView();
                vistaTicket.MdiParent = this;
                vistaTicket.FormClosed += vistaTicket_FormClosed;
                vistaTicket.Show();
            }
            else
            {
                vistaTicket.Activate();
            }
            
        }
        private void vistaTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            vistaTicket = null;
           
        }


        DetalleView vistaDetalle;
        private void DetalleToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetalleView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += vistaDetalle_FormClosed;
                vistaDetalle.Show();
            }
            else
            {
                vistaDetalle.Activate();
            }
            
        }
        private void vistaDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            vistaDetalle = null;
        }

    }
}
