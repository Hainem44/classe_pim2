using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe_pim2
{
    public partial class CRUDbabapet : Form
    {
        Cliente cliente;
        cliente_ctr cliente_ctr;
        public CRUDbabapet()
        {
            InitializeComponent(GetCRUDbabapet());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //doubleclickmaroto
        }

        private MaskedTextBox GetMaskedTextBox1()
        {
            return maskedTextBox1;
        }

        private void button1_Click(object sender, EventArgs e, MaskedTextBox maskedTextBox1)
        {
            cliente.CPF = Convert.ToInt16(value: maskedTextBox1.Text);
           


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente.CPF = Convert.ToInt16(maskedTextBox1.Text);
           
            //cliente_ctr.U_altera(usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.CPF = Convert.ToInt16(maskedTextBox1.Text);
            cliente_ctr.D_exclui(cliente);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            form2 form2 = new Form2(cliente);
            form2.Show();
            Application.Run(form2);
        }
    }
}
