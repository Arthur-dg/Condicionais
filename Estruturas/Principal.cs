using System;
using System.Text;

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
            // Laço de repetição que testa a condição no início
            // while (condição for verdadeira) {faça}
            
        {
            // Laço de repetição que testa a condição no início
            int num = 0;
            lsbMostra.Items.Clear();

            //Testa a condição do início
            while (num <= 100)
            { //condição

                // Bloco de execução
                lsbMostra.Items.Add(num + " x " + num + " = " + num*num);
                num++; //num + 1, ou num=+ 1
                

            }
        }

           
            
        

        private void btnDoWhile_Click(object sender, EventArgs e) {
            int a = 10;
            int x = 1;
            int fatorial = 1;
            lsbMostra.Items.Clear();

        do
        {
            fatorial = fatorial * x;
            lsbMostra.Items.Add(x + "! = " + fatorial);
            x++;
        }
            while (x <= a);

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
          lsbMostra.Items.Clear();

        int[] numeros = { 170, 121, 22, 787, 9 }; // os 5 números já setados

            int maior = numeros[0];
            int menor = numeros[0];

            for (int a = 0; a < numeros.Length; a++)
            {
                    if (numeros[a] > maior)
                        {
                             maior = numeros[a];
                        }

                    if (numeros[a] < menor)
                        {
                            menor = numeros[a];
                        }
            }

            lsbMostra.Items.Add("Maior número: " + maior);
            lsbMostra.Items.Add("Menor número: " + menor);
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            // for each
            // lista de personagens de amphoreus (HonkaiStarRail)

            string[] HeroisBangas = ["Zetian", "Angela", "Estes", "Floryn", "Pharsa", "Aurora", "Xavier", "Eudora", "Saber", "Miya", "Rafaela", "Guinevere"]; 
    
            foreach (string nomes in  HeroisBangas) {
                Console.WriteLine(nomes);
            }
        }
        private void btnBreak_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                if (cont == 2)
                {
                    break;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;

                if (cont == 2)
                {
                    continue;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }
    }
}
