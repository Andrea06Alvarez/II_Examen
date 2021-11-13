using Examen2_AndreaAlvarez.Modelos.DAO;
using Examen2_AndreaAlvarez.Modelos.Entidades;
using Examen2_AndreaAlvarez.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_AndreaAlvarez.Controladores
{
    public class TicketController
    {
        TicketsView vista;
        string GenerarTicket = string.Empty;
        TicketDAO ticketDAO = new TicketDAO();
        Ticket ticket = new Ticket();


        public TicketController(TicketsView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);


        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.NombreClienteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreClienteTextBox, "Ingrese el nombre");
                vista.NombreClienteTextBox.Focus();
                return;
            }

            if (vista.CantidadaTikectsTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.CantidadaTikectsTextBox, "Ingrese la cantidad de ticket");
                vista.CantidadaTikectsTextBox.Focus();
                return;
            }
            ticket.NombreCliente = vista.NombreClienteTextBox.Text;
            ticket.CantidadDeTicket = Convert.ToInt32(vista.CantidadaTikectsTextBox.Text);
            ticket.Fecha = vista.FechaDateTimePicker.Value;
            ticket.TipoDeSoporte = vista.TipoSoporteComboBox.Text;
            ticket.NombreEstado = vista.EstadoComboBox.Text;


            bool inserto = ticketDAO.InsertarNuevoTicket(ticket);

            if (inserto)
            {
                DesabilitarControles();
                LimpiarControles();

                MessageBox.Show ("Ticket ingresado exitosamente", "Atención", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo ingresar el ticket", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }


        private void Load(object sender, EventArgs e)
        {
            ListarTipoSoporte();
            ListarEstado();
        }

        private void ListarTipoSoporte()
        {
            vista.TipoSoporteComboBox.DataSource = ticketDAO.GetTipo();
            vista.TipoSoporteComboBox.DisplayMember = "TIPOSOPORTE";
            vista.TipoSoporteComboBox.ValueMember = "TIPODESOPORTE";
        }

        private void ListarEstado()
        {
            vista.EstadoComboBox.DataSource = ticketDAO.GetEstado();
            vista.EstadoComboBox.DisplayMember = "ESTADO";
            vista.EstadoComboBox.ValueMember = "NOMBREESTADO";
        }



        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            GenerarTicket = "Nuevo";
            ListarTipoSoporte();
            ListarEstado();

        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.NombreClienteTextBox.Enabled = true;
            vista.CantidadaTikectsTextBox.Enabled = true;
            vista.FechaDateTimePicker.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.NuevoButton.Enabled = false;
        }


        private void LimpiarControles()
        {

            vista.IdTextBox.Clear();
            vista.NombreClienteTextBox.Clear();
            vista.CantidadaTikectsTextBox.Clear();


            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.NuevoButton.Enabled = true;

        }

        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.NombreClienteTextBox.Enabled = false;
            vista.CantidadaTikectsTextBox.Enabled = false;
            vista.FechaDateTimePicker.Enabled = false;

        }


    }
}
