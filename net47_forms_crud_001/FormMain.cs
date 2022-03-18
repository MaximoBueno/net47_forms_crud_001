using net47_forms_crud_001.Data.Repositories;
using net47_forms_crud_001.Data.Repositories.Interfaces;
using net47_forms_crud_001.Forms;
using net47_forms_crud_001.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net47_forms_crud_001
{
    public partial class FormMain : Form
    {

        private IClienteRepository clienteRepository;
        private int id_cliente = 0;

        public FormMain()
        {
            InitializeComponent();
            iniciarClases();
            cargarListaClientes();
        }

        void iniciarClases()
        {
            clienteRepository = new ClienteRepository();
        }

        void limpiarDatosCliente()
        {
            id_cliente = 0;
            nombreTextBox.Text = "";
            a_paternoTextBox.Text = "";
            a_maternoTextBox.Text = "";
            correoTextBox.Text = "";
            nro_contactoTextBox.Text = "";
            nro_documentoTextBox.Text = "";
        }

        void estadoInicialBotones()
        {
            cancelarButton.Enabled = false;
            editarButton.Enabled = false;
            guardarButton.Enabled = true;
        }

        void cargarListaClientes()
        {
            clientesDataGridView.DataSource = null;
            clientesDataGridView.DataSource = clienteRepository.listar();

            if(clientesDataGridView.DataSource != null && clientesDataGridView.Columns.Count > 0)
            {
                clientesDataGridView.Columns[0].Visible = false;
            }
        }
       

        private void reporteButton_Click(object sender, EventArgs e)
        {
            using (var miReporte = new ReporteForm())
            {
                miReporte.ShowDialog();
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if(nombreTextBox.Text.Trim() != "" && 
                a_paternoTextBox.Text.Trim() != "" &&
                a_maternoTextBox.Text.Trim() != "" && 
                correoTextBox.Text.Trim() != "" &&
                nro_contactoTextBox.Text.Trim() != "" && 
                nro_documentoTextBox.Text.Trim() != "")
            {
                bool realizado = clienteRepository.guardar(new Models.ClienteModel
                {
                    nombres = nombreTextBox.Text,
                    ap_paterno = a_paternoTextBox.Text,
                    ap_materno = a_maternoTextBox.Text,
                    correo = correoTextBox.Text,
                    nro_contacto = nro_contactoTextBox.Text,
                    nro_documento = nro_documentoTextBox.Text
                });

                if(realizado)
                {
                    limpiarDatosCliente();
                    cargarListaClientes();
                }

                
            }
            else
            {
                MessageBox.Show("Ingresar datos correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Trim() != "" &&
                a_paternoTextBox.Text.Trim() != "" &&
                a_maternoTextBox.Text.Trim() != "" &&
                correoTextBox.Text.Trim() != "" &&
                nro_contactoTextBox.Text.Trim() != "" &&
                nro_documentoTextBox.Text.Trim() != "" && 
                id_cliente > 0)
            {
                bool realizado = clienteRepository.guardar(new Models.ClienteModel
                {
                    id = id_cliente,
                    nombres = nombreTextBox.Text,
                    ap_paterno = a_paternoTextBox.Text,
                    ap_materno = a_maternoTextBox.Text,
                    correo = correoTextBox.Text,
                    nro_contacto = nro_contactoTextBox.Text,
                    nro_documento = nro_documentoTextBox.Text
                });

                if (realizado)
                {
                    limpiarDatosCliente();
                    cargarListaClientes();
                    estadoInicialBotones();
                }
            }
            else
            {
                MessageBox.Show("Ingresar datos correctamente y/o seleccione a un cliente para editar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            estadoInicialBotones();
            limpiarDatosCliente();
        }

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_cliente = Convert.ToInt32(clientesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                nombreTextBox.Text = Convert.ToString(clientesDataGridView.Rows[e.RowIndex].Cells[1].Value);
                a_paternoTextBox.Text = Convert.ToString(clientesDataGridView.Rows[e.RowIndex].Cells[2].Value);
                a_maternoTextBox.Text = Convert.ToString(clientesDataGridView.Rows[e.RowIndex].Cells[3].Value);
                nro_documentoTextBox.Text = Convert.ToString(clientesDataGridView.Rows[e.RowIndex].Cells[4].Value);
                correoTextBox.Text = Convert.ToString(clientesDataGridView.Rows[e.RowIndex].Cells[5].Value);
                nro_contactoTextBox.Text = Convert.ToString(clientesDataGridView.Rows[e.RowIndex].Cells[6].Value);

                cancelarButton.Enabled = true;
                editarButton.Enabled = true;
                guardarButton.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
