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
            lsbMostra.Items.Clear();

            string usuario = txtUsuario.Txt;
            string senha = txtSenha.Txt;

            if (usuario == "admin" && senha == "1234")
            {
                lsbMostra.Items.Add("=== LOGIN REALIZADO ===");
                lsbMostra.Items.Add("Usuário ou senha incorretos.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // limpa os textos e a lista da tela
            txtUsuario.Clear();
            txtSenha.Clear();
            lsbMostra.Items.Clear();

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                lsbMostra.Items.Add(fatorial.ToString());
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num = 1;
            lsbMostra.Items.Clear();

            do
            {
                lsbMostra.Items.Add((num * num).ToString());
                num++;
            }
            while (num <= 5);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            lsbMostra.Items.Add("=== TABUADA DO 5 ===");
            lsbMostra.Items.Add("--------------------");

            int numero = 5;

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                lsbMostra.Items.Add($"{numero} x {i} = {resultado}");
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            // Array ou vetor é uma estrutura de dados que armazena
            // valores que podem ser acessados por uma posição
            // frutas[0] = "Maça", frutas[1] = "Mamão",.....
            string[] frutas = ["Maça", "Mamão", "Abacaxi", "Limão"];

            lsbMostra.Items.Clear();
            // lsbMostra.Items.Add(frutas[0]);
            // lsbMostra.Items.Add(frutas[1]);

            foreach (string coisas in frutas)
            {
                lsbMostra.Items.Add(coisas);
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
