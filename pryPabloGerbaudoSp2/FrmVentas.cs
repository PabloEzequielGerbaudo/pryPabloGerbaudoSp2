namespace pryPabloGerbaudoSp2
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        string numero;
        string tipo;
        int NTicket;
        string presentacion;
        private void txtNroTicket_TextChanged(object sender, EventArgs e)
        {
            if (txtNroTicket.Text != "")
            {

                cmbTipo.Enabled = true;
                numero = txtNroTicket.Text;
                NTicket = Convert.ToInt32(numero);
            }
            else
            {
                cmbTipo.Enabled = false;
            }

        }
        private void txtNroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
            tipo = cmbTipo.Text;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            presentacion = "Fecha: " + dtpFechaTicket.Text + " - Número de Ticket: " + NTicket + " - Tipo: " + tipo;
            lstVentas.Items.Add(presentacion);
            txtNroTicket.Clear();
            cmbTipo.SelectedIndex = -1;
            StreamWriter writer = new StreamWriter("Ventas.txt", true);
            writer.WriteLine(presentacion);
            writer.Close();
        }

        
    }

}
