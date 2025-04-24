using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmAplicativoAlunos : Form
    {
        public frmAplicativoAlunos()
        {
            InitializeComponent();
        }
        int a = 0;

        string[,] alunos = new string[3, 4];

        private void btncalcularmedia_Click(object sender, EventArgs e)
        {
            // adicionando alunos e percorrendo a matriz dos alunos

            alunos[0, 0] = txtnomealuno.Text;



            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if (i == 4)
                {

                    for (int j = 0; j < alunos.GetLength(0); j++)
                    {
                        alunos[i, j] = txtnomealuno.Text;
                        lstresultado.Items.Add(alunos[i, j]);
                    }

                }
                a++;
                
            }

            //lstresultado.Items.Clear();

            // Calculando a média

            //double soma = 0;

            //for (int j = 0; j < alunos.GetLength(0); j++)
            //{
            //    soma = [i, j];
            //}

            //float media = soma / alunos.GetLength(0);

            //// Adicionando a média na lista

            //lstresultado.Items.Add("Sua média é: " + i + ": " + media / 4);

        }

        private void btnlimparaplicativo_Click(object sender, EventArgs e)
        {
            txtnomealuno.Clear();
            txtnotaprova1.Clear();
            txtnotaprova2.Clear();
            txtnotaprova3.Clear();
            txtnotaprovatrabalho.Clear();
            lstresultado.Items.Clear();
        }

        private void btnsairaplicativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}





