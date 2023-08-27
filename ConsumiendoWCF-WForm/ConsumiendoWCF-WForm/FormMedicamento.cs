using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumiendoWCF_WForm.ServiceHospital;

namespace ConsumiendoWCF_WForm
{
    public partial class FormMedicamento : Form
    {
        public FormMedicamento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarMedicamento();
        }

        private void listarMedicamento()
        {
            ServiceHospitalClient oServiceHospital = new ServiceHospitalClient();
            IEnumerable<MedicamentoCLS> oListaMedicamento = oServiceHospital.listarMedicamento()
                .Where(p => p.habilitado == 1).ToList();

            dgMedicamento.DataSource = oListaMedicamento;
            //se deshabilitar columnas
            dgMedicamento.Columns["iidformafarmaceutica"].Visible = false;
            dgMedicamento.Columns["habilitado"].Visible = false;


        }

        private void toolStripLbNuveo_Click(object sender, EventArgs e)
        {
            frmPopupMedicamento frmPopupMedicamento = new frmPopupMedicamento();
            frmPopupMedicamento.iidMedicamento = 0;
            frmPopupMedicamento.ShowDialog();
            if (frmPopupMedicamento.DialogResult.Equals(DialogResult.OK))
            {
                listarMedicamento();
            }

        }

        private void toolStripLbEditar_Click(object sender, EventArgs e)
        {
            frmPopupMedicamento frmPopupMedicamento = new frmPopupMedicamento();
            int idMedicamento = (int)dgMedicamento.CurrentRow.Cells[0].Value;
            frmPopupMedicamento.iidMedicamento = idMedicamento;
            frmPopupMedicamento.ShowDialog();
            if (frmPopupMedicamento.DialogResult.Equals(DialogResult.OK))
            {
                listarMedicamento();
            }
        }

        private void toolStripLbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el Medicamento?", "Confirmacion",
                MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int iidMedicamento = (int)dgMedicamento.CurrentRow.Cells[0].Value;
                ServiceHospitalClient ServiceClient = new ServiceHospitalClient();
                int result = ServiceClient.eliminarMeidcamento(iidMedicamento);
                

                if (result == 1)
                {
                    MessageBox.Show("Se eliminó correctamente.");
                    listarMedicamento();
                }
                else
                {
                    MessageBox.Show("No se eliminó correctamente.");
                }
            }


        }
    }
}
