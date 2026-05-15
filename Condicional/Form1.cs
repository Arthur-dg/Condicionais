namespace Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "fulano.tal";
            string senha = "SemSenha999@";

            if (usuario == txtUsuário.Text && senha == txtSenha.Text)
            {
                MessageBox.Show("Seja bem-vindo ao nosso sistema!, " + usuario);
            }

            else
            {
                MessageBox.Show("Acesso Negado! :(");
            }

        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuário.Clear(); // ou txtUsuario.Text = "";
            txtSenha.Clear(); // ou txtSenha.Text = "";
            txtUsuário.Focus();
        }
    }
}
