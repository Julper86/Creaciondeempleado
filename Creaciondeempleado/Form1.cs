namespace Creaciondeempleado
{
    public partial class Form1 : Form
    {
        frmDatosBasicos FormDatos;
        frmLogin Formlogin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtRegistro_Click(object sender, EventArgs e)
        {
            frmDatosBasicos frmDatosBasicos = new frmDatosBasicos();
            frmDatosBasicos.Show();
        }
    }
}