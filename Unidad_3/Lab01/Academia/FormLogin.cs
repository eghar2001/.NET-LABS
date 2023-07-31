namespace Academia
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "admin" && this.txtPass.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sos un salame, aprendete tu usuario y contraseña y volvé", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pretendes que te recuerde la contraseña?", "Olvide mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}