using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando as variaveis
            double num1, num2, resp = 0;
            try
            {

                //inicializar as variaveis

                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rbSomar.Checked == false &&
                    rbSubtrair.Checked == false &&
                    rbMultiplicar.Checked == false &&
                    rbDivisão.Checked == false)
                {
                    MessageBox.Show("Selecione uma operação", "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {

                    if (rbSomar.Checked)
                    {


                        resp = num1 + num2;

                    }
                    if (rbSubtrair.Checked)
                    {

                        resp = num1 - num2;

                    }

                    if (rbMultiplicar.Checked)
                    {

                        resp = num1 * num2;

                    }
                    if (rbDivisão.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossivel dividir por zero", "Mensagem do sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button3);
                            resp = 0;
                        }

                    }
                    else
                    {
                        resp = num1 / num2;

                    }
                    txtResposta.Text = resp.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtNumero1.Clear();
                txtNumero2.Clear();
                txtNumero1.Focus();


                {
                    MessageBox.Show("Impossivel dividir por zero", "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnLimpar(object sender, EventArgs e)
        {

            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResposta.Text = "";






            rbSomar.Checked = false;

            rbSubtrair.Checked = false;

            rbMultiplicar.Checked = false;

            rbDivisão.Checked = false;

            lblNumero1.Focus();
        }



        private void btnSair(object sender, EventArgs e)
        {
            //Application.Exit();
        }
    }

}
        
         

