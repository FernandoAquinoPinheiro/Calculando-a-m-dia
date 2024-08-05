using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //Declarar variaveis
            string nome, resultado;
            double n1, n2, media;

            //entrada de dados
            nome = textBoxNome.Text;
            n1 = double.Parse(textBoxNota1.Text);
            n2 = double.Parse(textBoxNota2.Text);

            //Calculando

            media = (n1 + n2) / 2;

            if(media >= 7)
            {
                
                resultado = "Aprovado";

            }
            else if(media < 4 ) 
            {
                
                resultado = "Reprovado";

            }
            else 
            {

                resultado = "Recuperação";
                    
            }

            //Saida

            textBoxMedia.Text = media.ToString();
            textBoxResultado.Text = resultado;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

            textBoxNome.Clear();
            textBoxNota1.Clear();
            textBoxNota2.Clear();
            textBoxMedia.Clear();
            textBoxResultado.Clear();

            textBoxNome.Focus();
        }
    }
}
