using System;

namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Laço de repetição que testa a condição no início
            int num = 0;
            int i = 8;
            lsbMostra.Items.Clear();

            //Testa a condição do início
            while (num <= 10)
            { //condição

                // Bloco de execução
                lsbMostra.Items.Add(i + " x " + num + " = " + i*num);
                num++; //num + 1, ou num=+ 1

            }
        }


        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int a = 7;
            int x = 0;
            lsbMostra.Items.Clear();
            // Testa a condição no final
            do
            {
                lsbMostra.Items.Add(a + " x " + x + " = " + a * x);
                x++;
            }
            while (x <= 10);

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();


            int w = 5;
            for (int a = 0; a <= 10; a++) 
            {
                lsbMostra.Items.Add(w + " x " + a + " = "+ w*a);
            }
        }
    }
}
