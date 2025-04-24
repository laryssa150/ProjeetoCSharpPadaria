using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class Vetores : Form
    {
        public Vetores()
        {
            InitializeComponent();
        }
        int i = 0;
        int a = 0;
        string[] nome = new string[0];

        private void btn1_Click(object sender, EventArgs e)
        {
           

            carregaVetores();
           

        }

        public void carregaVetores()
        {
            int tamanho = int.Parse(txtB1.Text); // Lendo o tamanho do vetor ou array de linha

            // Criando um vetor ou array de linha

            string[] nome = new string[tamanho];

            // Inserindo valores manualmente no vetor
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = txtB2Nome.Text;
            }


            //nome[0] = "Maria";
            //nome[1] = "José";
            //nome[2] = "João";
            //nome[3] = "Ana";
            //nome[4] = "Pedro";
            //nome[5] = "Lucas";
            //nome[6] = "Marcos";
            //nome[7] = "Paulo";
            //nome[8] = "Carla";
            //nome[9] = "Fernanda";

            ltbNomes.Items.Clear();

            //percorrendo o vetor de linha ou matriz de linha
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = txtB2Nome.Text;
                ltbNomes.Items.Add(nome[i]);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            nome[a] = txtB2Nome.Text;

            string[] nomes = new string[3];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = txtB2Nome.Text;
                ltbNomes.Items.Add(nomes[i]);
            }

            if (txtB2Nome.Text == "")
            {
                MessageBox.Show("digite um nome");
            }
            else
            {
                MessageBox.Show("Nome adicionado com sucesso");
            }

            
        }

      
    }
    }
