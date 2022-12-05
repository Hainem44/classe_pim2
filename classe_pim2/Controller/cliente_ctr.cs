using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classe_pim2.Model;
using classe_pim2.Daoo;


namespace classe_pim2
{
    class cliente_ctr
    {
        Dao_Cliente dao_cliente;
        List<Cliente> lista_cliente;
        internal void D_exclui(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente N_cliente(Cliente cliente) => Dao_Cliente.create(cliente);
    }

    


}
