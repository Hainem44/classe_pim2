using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_pim2
{
    class pet
    {
        public string nome { get; set; }
        public int id_pet { get; set; }
        public string descricao_pet { get; set; }
        public string raça { get; set; }

        public Cliente cli;

        public pet()
        {
            cli = new Cliente();
        }







    }
}
