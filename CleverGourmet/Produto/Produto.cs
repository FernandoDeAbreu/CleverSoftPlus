using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Produto
{
    class Produto
    {

        Conexao conexao = new Conexao();
       public string sqlProduto;
       public int ID;
       public string DESCRICAO;
       public string CODAUXILIAR;
       public string MEDIDA;
       public decimal PCUSTO;
       public decimal ESTOQUE;
       public decimal PVENDA;
       public string DTEXCLUSAO;
       public string IMG;
       public string IDSECAO;
       public string TIPO;
       public string NS;
       public string OBS;


       
        
        public void select()
        {

            string descricao;
            string codigoAuxiliar;


            if (DESCRICAO != null)
            {
                descricao = " LIKE '%" + DESCRICAO + "%'";
            }
            else
            {
                descricao = " IS NOT NULL ";
            }

            if (CODAUXILIAR != null)
            {
                codigoAuxiliar = " = '" + CODAUXILIAR + "'";
            }
            else
            {
                codigoAuxiliar = " IS NOT NULL ";
            }

         

            sqlProduto = " SELECT         " +
                                " P.ID,               " +
                                " P.DESCRICAO,        " +
                                " P.CODAUXILIAR,      " +
                                " P.MEDIDA,           " +
                                " P.PCUSTO,           " +
                                " P.ESTOQUE,          " +
                                " P.PVENDA,           " +
                                " P.IMG,              " +
                                " S.IDDEPTO,          " +
                                " D.DEPARTAMENTO,     " +
                                " P.IDSECAO,          " +
                                " S.SECAO,             " +
                                " P.TIPO,             " +
                                " P.NS,               " +
                                " P.OBS               " +
                                "                     " +
                                " FROM                " +
                                " TBPRODUTO P,        " +
                                " TBDEPTO   D,        " +
                                " TBSECAO S           " +
                                "                     " +
                                " WHERE               " +
                                "                     " +
                                " P.IDSECAO = S.ID AND" +
                                " S.IDDEPTO = D.ID  AND P.DTEXCLUSAO IS NULL AND P.DESCRICAO " + descricao + " AND P.CODAUXILIAR " + codigoAuxiliar;

        }
        public void insert()
        {

            try
            {
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBPRODUTO   " +
                                                      "(DESCRICAO     " +
                                                      ",CODAUXILIAR   " +
                                                      ",MEDIDA        " +
                                                      ",PCUSTO        " +
                                                      ",ESTOQUE       " +
                                                      ",IMG           " +
                                                      ",IDSECAO       " +
                                                      ",PVENDA        " +
                                                      ",TIPO          " +
                                                      ",NS            " +
                                                      ",OBS)           " +
                                                      "VALUES         " +
                                                      "(@DESCRICAO    " +
                                                      ",@CODAUXILIAR  " +
                                                      ",@MEDIDA       " +
                                                      ",@PCUSTO       " +
                                                      ",@ESTOQUE      " +
                                                      ",@IMG          " +
                                                      ",@IDSECAO      " +
                                                      ",@PVENDA       " +
                                                      ",@TIPO         " +
                                                      ",@NS           " +
                                                      ",@OBS)         ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO",   DESCRICAO);
                    conexao.cmd.Parameters.AddWithValue("CODAUXILIAR", CODAUXILIAR);
                    conexao.cmd.Parameters.AddWithValue("MEDIDA",      MEDIDA);
                    conexao.cmd.Parameters.AddWithValue("PCUSTO",      PCUSTO);
                    conexao.cmd.Parameters.AddWithValue("ESTOQUE",     ESTOQUE);
                    conexao.cmd.Parameters.AddWithValue("IMG",         IMG);
                    conexao.cmd.Parameters.AddWithValue("IDSECAO",     IDSECAO);
                    conexao.cmd.Parameters.AddWithValue("PVENDA",      PVENDA);
                    conexao.cmd.Parameters.AddWithValue("TIPO",        TIPO);
                    conexao.cmd.Parameters.AddWithValue("NS",          NS);
                    conexao.cmd.Parameters.AddWithValue("OBS",         OBS);


                    conexao.cmd.ExecuteNonQuery();


                    conexao.Fecha_Conexao();
            }
            
            catch (Exception ex)
            {
                string frase = ex.Message;
                string palavra = "UNIQUE";

                if (frase.Contains(palavra))
                {
                    MessageBox.Show("Código auxiliar já cadastrado", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void update()
        {
            try
            {
                conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET " +
                                              " DESCRICAO   = @DESCRICAO    " +
                                              ",CODAUXILIAR = @CODAUXILIAR  " +
                                              ",MEDIDA      = @MEDIDA       " +
                                              ",PCUSTO      = @PCUSTO       " +
                                              ",ESTOQUE     = @ESTOQUE      " +
                                              ",IMG         = @IMG      " +
                                              ",IDSECAO     = @IDSECAO      " +
                                              ",PVENDA      = @PVENDA        " +
                                              ",TIPO        = @TIPO        " +
                                              ",NS          = @NS        " +
                                              ",OBS         = @OBS        " +
                                              " WHERE  ID = " + ID;



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("DESCRICAO",   DESCRICAO);
            conexao.cmd.Parameters.AddWithValue("CODAUXILIAR", CODAUXILIAR);
            conexao.cmd.Parameters.AddWithValue("MEDIDA",      MEDIDA);
            conexao.cmd.Parameters.AddWithValue("PCUSTO",      PCUSTO);
            conexao.cmd.Parameters.AddWithValue("ESTOQUE",     ESTOQUE);
            conexao.cmd.Parameters.AddWithValue("IMG",         IMG);
            conexao.cmd.Parameters.AddWithValue("IDSECAO",     IDSECAO);
            conexao.cmd.Parameters.AddWithValue("PVENDA",      PVENDA);
            conexao.cmd.Parameters.AddWithValue("TIPO",        TIPO);
            conexao.cmd.Parameters.AddWithValue("NS",          NS);
            conexao.cmd.Parameters.AddWithValue("OBS",         OBS);
            conexao.cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexao.Fecha_Conexao();
            }

            catch (Exception ex)
            {
                string frase = ex.Message;
                string palavra = "UNIQUE";

                if (frase.Contains(palavra))
                {
                    MessageBox.Show("Código auxiliar já cadastrado", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
