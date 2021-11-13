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
    public class EstadoController
    {

        EstadoView vista;
        string operarestado = string.Empty;
        EstadoDAO estadoDAO = new EstadoDAO();
        Estado estado = new Estado();

        public EstadoController(EstadoView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(NuevoEstado);
            vista.GuardarButton.Click += new EventHandler(GuardarEstado);
            vista.Load += new EventHandler(Load);
            vista.EliminarButton.Click += new EventHandler(EliminarEstado);
        }

        private void EliminarEstado(object serder, EventArgs e)
        {
            if (vista.EstadoDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = estadoDAO.EliminarTipoSoporte(Convert.ToInt32(vista.EstadoDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    ListarEstado();
                    MessageBox.Show("Eliminado exitosamente", "Atención", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                }


            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarEstado();
        }

        public EstadoController()
        {
        }
        private void GuardarEstado(object serder, EventArgs e)
        {
            if (vista.NombreEstadoTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreEstadoTextBox, "Ingrese el tipo de soporte que necesita");
                vista.NombreEstadoTextBox.Focus();
                return;
            }




            estado.Nombre = vista.NombreEstadoTextBox.Text;

            bool inserto = estadoDAO.InsertarNuevoEstado(estado);

            if (inserto)
            {
                DesabilitarControles();
                LimpiarControles();
                ListarEstado();
                MessageBox.Show("Ingresado exitosamente", "Atención", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }



        }

        private void ListarEstado()
        {
            vista.EstadoDataGridView.DataSource = estadoDAO.GetUsuarios();
        }
        private void NuevoEstado(object serder, EventArgs e)
        {
            HabilitarControles();
            operarestado = "Nuevo";

        }


        private void HabilitarControles()
        {
            vista.CodigoeEstadoTextBox.Enabled = true;
            vista.NombreEstadoTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.EliminarButton.Enabled = true;
            vista.NuevoButton.Enabled = false;
        }


        private void LimpiarControles()
        {
            vista.NombreEstadoTextBox.Clear();


            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.EliminarButton.Enabled = false;
            vista.NuevoButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            vista.NombreEstadoTextBox.Enabled = false;

        }

    }
}

