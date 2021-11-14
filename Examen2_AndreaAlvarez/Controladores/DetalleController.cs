using Examen2_AndreaAlvarez.Modelos.DAO;
using Examen2_AndreaAlvarez.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_AndreaAlvarez.Controladores
{
    public class DetalleController
    {
        DetalleView vista;
        TicketDAO ticketDAO = new TicketDAO();

        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTicket();
        }

        private void ListarTicket()
        {
            vista.DetalleDataGridView.DataSource = ticketDAO.GetTicket();
        }

        private void Eliminar(object serder, EventArgs e)
        {
            if (vista.DetalleDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = ticketDAO.EliminarTicket(Convert.ToInt32(vista.DetalleDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    ListarTicket();
                    MessageBox.Show("Ticket eliminado exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

    }
}
