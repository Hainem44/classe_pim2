using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_pim2
{
    class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string senha { get; set; }
        public string nomePet { get; set; }
        public int id_pet { get; set; }
        public string descricao_pet { get; set; }
        public string raça { get; set; }
        public double CEP { get; set; }
        public string RUA { get; set; }
        public string BAIRRO { get; set; }
        public string ESTADO { get; set; }
    }

}