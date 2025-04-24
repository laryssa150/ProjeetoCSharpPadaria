using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmEstrutraRepeticao : Form
    {
        public frmEstrutraRepeticao()
        {
            InitializeComponent();
        }

        private void btnCarregaEstado_Click(object sender, EventArgs e)
        {
            //executando o método carrega combo
            carregaCombo();

        }

        //criando o método carrega combo
        public void carregaCombo()
        {
            cbbEstado.Items.Clear();
            cbbEstado.Items.Add("Capão Redondo");
            cbbEstado.Items.Add("São Luiz");
            cbbEstado.Items.Add("Campo Grande");
            cbbEstado.Items.Add("Piraporinha");
            cbbEstado.Items.Add("Jardim Angela");
            cbbEstado.Items.Add("Vila Remo");
            cbbEstado.Items.Add("Capelinha");
            cbbEstado.Items.Add("Campo Limpo");
            cbbEstado.Items.Add("Jardim Jacira");
            cbbEstado.Items.Add("Jardim Nakamura");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Equals (""))
             {
                MessageBox.Show("Favor digitar um estado");
             }
            
            else
            {
                if(e.KeyCode == Keys.Enter && textBox1.Text != "")
                {
                    //();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ltbListaDesejos.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ltbListaDesejos.Items.RemoveAt(ltbListaDesejos.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
