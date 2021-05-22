using System;
using System.Linq;
using System.Windows.Forms;

namespace SGC_Winform
{
    public partial class ConfiguracaoForm : Form
    {
        public ConfiguracaoForm()
        {
            InitializeComponent();
        }

        private string  Ordenar(string textoOriginal)
        {
            char[] vetorNome = textoOriginal.ToArray();
            int i = 0;
            int tamanhoTotal = vetorNome.Length;
            int qtde = 0;
            char aux;
            while (true)
            {
                //se chegou ao final
                if (i == tamanhoTotal - 1)
                {
                    break;
                }
                else


                if (vetorNome[i] > vetorNome[i + 1])
                {
                    aux = vetorNome[i];
                    vetorNome[i] = vetorNome[1 + i];
                    vetorNome[i + 1] = aux;
                    i = 0;
                }
                else
                    i++;

                qtde++;
            }
            string textoSaida = "";

            for (int j = 0; j < vetorNome.Length; j++) 
            
                textoSaida += vetorNome[j].ToString();

                return textoSaida;

            
            //MessageBox.Show("Pronto!\n" + qtde + "execuções");
        }

        private void ordenarButton_Click(object sender, EventArgs e)
        {
            texto2TextBox.Text = Ordenar(texto1TextBox.Text);
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] vetorNome = texto1TextBox.Text.ToArray();
            var vetorNomeOrdenado1 = vetorNome.OrderBy(o => o).ToArray();
            var vetorNomeOrdenado2 = vetorNome.OrderByDescending(o => o).ToArray();

            var teste2 = vetorNome.ToArray();
            Array.Sort(teste2);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vetorString = texto1TextBox.Text.Split(',');

            int[] vetorNumeros = new int[vetorString.Length];

            for (int i = 0; i < vetorString.Length; i++)
            {
                vetorNumeros[i] = Convert.ToInt32(vetorString[i]);
            }
            Array.Sort(vetorNumeros);
            // var vetor = Ordenar(texto1TextBox.Text).ToArray
            texto2TextBox.Text = string.Join(", ", vetorNumeros);
        }
    }
}
