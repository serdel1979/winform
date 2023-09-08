using capaEntidad;

namespace capaNegocio
{
    public class CNCliente
    {

        public bool ValidarDatos(CECliente cliente)
        {
            bool resultado = true;
            if(cliente.Nombre == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            
            if (cliente.Apellido == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }

            if(cliente.Foto == null)
            {
                resultado = false;
                MessageBox.Show("La foto es obligatoria");
            }

            return resultado;
        }

    }
}