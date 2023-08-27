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
    public partial class frmPopupMedicamento : Form
    {
        public int iidMedicamento { get; set; }
        public frmPopupMedicamento()
        {
            InitializeComponent();
        }


        private void frmPopupMedicamento_Load(object sender, EventArgs e)
        {
            ServiceHospitalClient oHospital = new ServiceHospitalClient();
 
            IEnumerable<FormaFarmaceuticaCLS> ListaForma = oHospital.listarFormaceutica();
            ListaForma.ToList().Add(new FormaFarmaceuticaCLS {iidFormafarmaceutica = 0, Nombre = "Seleccione una opcion" });
            cbFormaFarmaceutica.DataSource = ListaForma;
            cbFormaFarmaceutica.DisplayMember = "Nombre";
            cbFormaFarmaceutica.ValueMember = "iidFormafarmaceutica";


            if (iidMedicamento == 0)
            {
                this.Text = "Agregando Medicamento";
            }
            else
            {
                ServiceHospitalClient oHospitalMedicamentoEditar = new ServiceHospitalClient();

               
                this.Text = "Editando Medicamento";
               MedicamentoCLS result = oHospitalMedicamentoEditar.recuperarMedicamento(iidMedicamento);
                txtIMedicamento.Text = result.IIdMedicamento.ToString();
                txtNombre.Text = result.nombre;
                txtPrecio.Text = result.Precio.ToString();
                txtConcentracion.Text = result.concentracion.ToString();
                txtPresentacion.Text = result.presentacion.ToString();
                txtStock.Text = result.stock.ToString();
                cbFormaFarmaceutica.SelectedValue = result.iidFormaFarmaceutica;
            }


        }

        private void keyPressStock(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SoloDecimales(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar==',')
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            bool exito = true;
            //Validacion de texto
            if (txtNombre.Text =="")
            {
                errorProvider.SetError(txtNombre, "Ingrese un Nombre");
                exito = false;
            }else
            {
                errorProvider.SetError(txtNombre, "");
            }
            // Validacion de precio
            if (txtPrecio.Text == "")
            {
                errorProvider.SetError(txtPrecio, "Ingrese un Precio");
                exito = false;
            }
            else
            {
                errorProvider.SetError(txtPrecio, "");
            }
            // Validacion de concentracion
            if (txtConcentracion.Text == "")
            {
                errorProvider.SetError(txtConcentracion, "Ingrese un concentracion");
                exito = false;
            }
            else
            {
                errorProvider.SetError(txtPrecio, "");
            }
            // Validacion de presentacion
            if (txtPresentacion.Text == "")
            {
                errorProvider.SetError(txtPresentacion, "Ingrese un presentacion");
                exito = false;
            }
            else
            {
                errorProvider.SetError(txtPresentacion, "");
            }

            // Validacion de concentracion
            if ((int)cbFormaFarmaceutica.SelectedValue == 0)
            {
                errorProvider.SetError(cbFormaFarmaceutica, "Ingrese un FormaFarmaceutica");
                exito = false;
            }
            else
            { 
                errorProvider.SetError(cbFormaFarmaceutica, "");
            }

            /* Validacion de concentracion
            if ((int)cbFormaFarmaceutica.SelectedValue != 0)
            {
                errorProvider.SetError(cbFormaFarmaceutica, "Ingrese un FormaFarmaceutica");
                exito = false;
            }
            else
            {
                errorProvider.SetError(cbFormaFarmaceutica, "");
            }
            */
            if (exito == false)
            {
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                MedicamentoCLS oMedicamento = new MedicamentoCLS();
                oMedicamento.IIdMedicamento = int.Parse(txtIMedicamento.Text);
                oMedicamento.nombre = txtNombre.Text;
                oMedicamento.presentacion = txtPresentacion.Text;
                oMedicamento.Precio = decimal.Parse(txtPrecio.Text);
                oMedicamento.concentracion = txtConcentracion.Text;
                oMedicamento.iidFormaFarmaceutica = (int)cbFormaFarmaceutica.SelectedValue;
                oMedicamento.stock = int.Parse(txtStock.Text);

                ServiceHospitalClient oHospitalMedicamentoEditar = new ServiceHospitalClient();
                var result = oHospitalMedicamentoEditar.agregarYActualizarMedicamento(oMedicamento);
                if (result ==1)
                {
                    MessageBox.Show("Se ejecuto Correctamente");
                    DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Ocurrio un error");
                    DialogResult= DialogResult.None;
                }

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
