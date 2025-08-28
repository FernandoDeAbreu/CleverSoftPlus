using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverSoft
{
   public class AcessoRotina
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;
        string nomeRotina;

        private void pesquisar_Rotina()
        {

            conexao.Abre_Conexao();
            SQLCunsultaEmpr = "SELECT COUNT(NOMEROTINA) FROM TBROTINAS WHERE NOMEROTINA = '" + nomeRotina + "'";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            string o = "";


            while (conexao.dataReader.Read())
            {
                o = conexao.dataReader[0].ToString();
            }
            conexao.Fecha_Conexao();

            if (o == "0")
            {
                gravaNomeRotina();
            }
        }

        private void gravaNomeRotina()
        {
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "INSERT INTO TBROTINAS (NOMEROTINA) VALUES (@NOMEROTINA)";


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("NOMEROTINA", nomeRotina);

            conexao.cmd.ExecuteNonQuery();

            conexao.Fecha_Conexao();
        }

        public void verificarAcesso(string nomeRotina, string idFunc)
        {
            pesquisar_Rotina();
            conexao.Abre_Conexao();
            SQLCunsultaEmpr = "SELECT COUNT(ID) FROM TBPERMISSAO WHERE NOMEROTINA = '" + nomeRotina + "' AND IDFUNC = " + idFunc;



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            string o = "";


            while (conexao.dataReader.Read())
            {
                o = conexao.dataReader[0].ToString();
            }
            conexao.Fecha_Conexao();

            if (o == "0")
            {
              
            }
        }

    }
}
