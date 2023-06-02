using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creaciondeempleado
{
    public partial class frmDatosBasicos : Form
    {

        private Persona objersona;
        private MetodosPersona objmetodos = new MetodosPersona();
        public frmDatosBasicos()
        {
            InitializeComponent();
        }

        private void Dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtGrabar_Click(object sender, EventArgs e)
        {
            objersona = new Persona();

            //indicamos de donde y a donde adicionar las variables
            objersona.Id = Convert.ToInt32(TxtId.Text);
            objersona.Nombre = TxtNombre.Text;
            objersona.Apellido = TxtApellido.Text;
            objersona.direccion = TxtDireccion.Text;
            objersona.telefono = TxtTelefono.Text;
            objersona.celular = TxtCelular.Text;
            objersona.correo = TxtCorreo.Text;


            if (RdbTId.Checked == true)
            {
                objersona.Tdoc = RdbTId.Text;
            }
            else if (RdbCedula.Checked == true)
            {
                objersona.Tdoc = RdbCedula.Text;
            }
            else if (RdbViudo.Checked == true)
            {
                objersona.Tdoc = RdbViudo.Text;
            }
            else
            {
                MessageBox.Show("obligatoriamente debe selexionar un Tipo de identificacion");
                return;
            }

            //validar si selecciono un tipo de genero
            if (RdbMasculino.Checked == true)
            {
                objersona.sexo = RdbMasculino.Text;
            }
            else if (RdbFemenino.Checked == true)
            {
                objersona.sexo = RdbFemenino.Text;
            }
            else
            {
                MessageBox.Show("obligatoriamente debe selexionar un sexo");
                return;
            }



            if (RdbSoltero.Checked == true)
            {
                objersona.Ecivil = RdbSoltero.Text;
            }
            else if (RdbCasado.Checked == true)
            {
                objersona.Ecivil = RdbCasado.Text;
            }
            else if (RdbUnionlibre.Checked == true)
            {
                objersona.Ecivil = RdbUnionlibre.Text;
            }
            else if (RdbViudo.Checked == true)
            {
                objersona.Ecivil = RdbViudo.Text;
            }
            else if (RdbDivorciado.Checked == true)
            {
                objersona.Ecivil = RdbDivorciado.Text;
            }
            else
            {
                MessageBox.Show("obligatoriamente debe selexionar un Tipo de identificacion");
                return;
            }

            //adicionar la fecha
            if (validarfecha() == false)
            {
                return;
            }
            else
            {
                objersona.Fecha = DtFecha.Value.Date;
            }




            objmetodos.adicionar(objersona);
            //indicar al data gred vew de donde obtener la informacion
            Dtgv.DataSource = null;
            Dtgv.DataSource = objmetodos.listametodos;



            MessageBox.Show("Datos adicionados con exito", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void frmDatosBasicos_Load(object sender, EventArgs e)
        {

        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {

        }

        private bool validarfecha()
        {
            DateTime hoy = DateTime.Today;
            if (DtFecha.Value.Date >= hoy)
            {
                MessageBox.Show("fecha invalida");
                return false;
            }
            else if (DtFecha.Value.Date.AddYears(18) >= hoy)
            {
                return true;
            }
            else
            {
                MessageBox.Show("error fecha invalida");
                return false;
            }
        }





























    }
}
