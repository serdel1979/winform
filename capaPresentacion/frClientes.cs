using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class frClientes : Form
    {

        CNCliente cNCliente = new CNCliente();
        public frClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            picFoto.Image = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(openFileDialog1.FileName);
            }
            openFileDialog1.FileName = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new CECliente();

            if(txtId.Text  == string.Empty) {
                cliente.Id = 0;
            }
            else 
            {
                cliente.Id = int.Parse(txtId.Text);
            };
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Foto = picFoto.ImageLocation;

            if (!cNCliente.ValidarDatos(cliente))
            {
                return;
            }

            MessageBox.Show("Datos guardados");
        }
    }
}