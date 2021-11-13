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
    public class TiposController
    {
        TiposView vista;
        string operacion = string.Empty;
        TipoDAO userDAO = new TipoDAO();
        Tipos user = new Tipos();

        public TiposController(TiposView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
        }

        private void Eliminar(object serder, EventArgs e)
        {
            if (vista.tiposDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = userDAO.EliminarTipoSoporte(Convert.ToInt32(vista.tiposDataGridView.CurrentRow.Cells[0].Value.ToString()));

                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    ListarTipoSoporte();
                    MessageBox.Show("Eliminado exitosamente", "Atención", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                }
                

            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarTipoSoporte();
        }

        public TiposController()
        {
        }
        private void Guardar(object serder, EventArgs e)
        {
            if (vista.TipoTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.TipoTextBox, "Ingrese el tipo de soporte que necesita");
                vista.TipoTextBox.Focus();
                return;
            }

            

          
            user.TipoSoporte = vista.TipoTextBox.Text;

           bool inserto = userDAO.InsertarNuevoTipodeSoporte(user);

            if (inserto)
            {
                DesabilitarControles();
                LimpiarControles();
                ListarTipoSoporte();
                MessageBox.Show("Ingresado exitosamente", "Atención", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        


        }

        private void ListarTipoSoporte()
        {
            vista.tiposDataGridView.DataSource = userDAO.GetUsuarios();
        }
        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
          
        }


        private void HabilitarControles()
        {
            vista.CodigoTextBox.Enabled = true;
            vista.TipoTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.EliminarButton.Enabled = true;
            vista.NuevoButton.Enabled = false;
        }


        private void LimpiarControles()
        {
            vista.TipoTextBox.Clear();


            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.EliminarButton.Enabled = false;
            vista.NuevoButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            vista.TipoTextBox.Enabled = false;
            
        }

    }
}
