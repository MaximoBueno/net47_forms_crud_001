using net47_forms_crud_001.Data.Repositories;
using net47_forms_crud_001.Data.Repositories.Interfaces;
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

namespace net47_forms_crud_001.Forms
{
    public partial class ReporteForm : Form
    {
        private IClienteRepository clienteRepository;

        public ReporteForm()
        {
            InitializeComponent();
            cargarListaClientes();
        }

        void cargarListaClientes()
        {
            clienteRepository = new ClienteRepository();
            ListaClientesCrystalReport lista = new ListaClientesCrystalReport();

            lista.SetDataSource(clienteRepository.listar());
            reporteCrystalReportViewer.ReportSource = lista;
        }
    }
}
