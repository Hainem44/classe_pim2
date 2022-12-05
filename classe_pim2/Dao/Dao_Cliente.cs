using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.OleDb;
using classe_pim2.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace classe_pim2
{
    class Dao_Cliente
    {
        OleDbConnection conexao;

        public Dao_Cliente(string banco)
        {
            // conexao = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+banco+"; Extended Properties =’Excel 12.0 Xml; HDR = YES’;");
            conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + banco + "; Extended Properties = 'Excel 8.0;HDR=YES;ReadOnly=False'");
        }

        public void create(Cliente cliente)
        {
            string comandoSql = "INSERT INTO [Cliente$] [NOME],[CPF],[TELEFONE],[SENHA]) VALUES (@NOME,@CPF,@TELEFONE,@SENHA)";

            OleDbCommand comando = new OleDbCommand(comandoSql, conexao);

            comando.Parameters.Add("@CPF", OleDbType.VarChar, 255).Value = cliente.cpf;


            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conexao.Close();

            }


        }



    }
}