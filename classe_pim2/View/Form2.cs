using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classe_pim2.Model;

namespace classe_pim2
{
    public partial class form2 : Form
    {
        Cliente cliente;
        private Cliente cliente1;

        public form2()
        {
        }

        //public form2(Cliente cliente) => this.cliente = cliente;

        public static implicit operator form2(CRUDbabapet v)
        {
            throw new NotImplementedException();
        }

        // public Form2(Cliente cliente) => this.cliente = cliente;

        /*public Form2(cliente aux)
        {
            cliente = new Cliente();
            InitializeComponent();
            cliente = aux;
        }

        public Form2(Cliente cliente1) => this.cliente1 = cliente1;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }*/
    }

    internal class Cliente
    {
        internal string nome;
        internal string telefone;
        internal string senha;

        public string ESTADO { get; internal set; }
        public short CPF { get; internal set; }
        public double CEP { get; internal set; }
        public string BAIRRO { get; internal set; }
        public string RUA { get; internal set; }

       
   
        }
    }

