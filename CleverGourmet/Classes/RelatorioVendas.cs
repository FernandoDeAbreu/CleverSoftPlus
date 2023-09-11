using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverSoft
{
    class RelatorioVendas
    {
        public int idVendaCupom;
        string sqlCupom;
        public void gerarCupom()
        {
            sqlCupom = " SELECT            " +
                     "                           " +
                     "  V.ID                      " +
                     " ,V.DATA                   " +
                     " ,V.HORA                   " +
                     " ,V.VLRORIGINAL            " +
                     " ,V.VLRDESC                " +
                     " ,V.VLRPAGO                " +
                     " ,V.VLRVENDA               " +
                     " ,V.VLRTROCO               " +
                     " ,V.STATUS                 " +
                     "                           " +
                     " ,V.IDFILIAL               " +
                     " ,A.RAZAOSOCIAL AS NOMEFILIAL     " +
                     " ,A.FANTASIA             " +
                     " ,A.TIPOPESSOA             " +
                     " ,A.CNPJ_CPF               " +
                     " ,A.IE_RG                  " +
                     " ,A.DTNASC                 " +
                     " ,A.CEP                    " +
                     " ,A.CIDADE                 " +
                     " ,A.UF                     " +
                     " ,A.BAIRRO                 " +
                     " ,A.ENDERECO               " +
                     " ,A.NUM                    " +
                     " ,A.COMPLEMENTO            " +
                     " ,A.CELULAR                " +
                     " ,A.TELEFONE               " +
                     " ,A.WHATSAPP               " +
                     " ,A.RODAPECUPOM            " +
                     "                           " +
                     " ,V.IDFUNC                 " +
                     " ,E.NOME AS NOMEFUNC       " +
                     " ,E.CPF                    " +
                     " ,E.USUARIO                " +
                     "                           " +
                     " ,V.IDCLIENTE              " +
                     " ,C.RAZAOSOCIAL AS C_NOME                  " +
                     " ,C.TIPOPESSOA  AS C_TIPOPESSOA            " +
                     " ,C.CNPJ_CPF    AS C_CNPJ_CPF              " +
                     " ,C.IE_RG       AS C_IE_RG                 " +
                     " ,C.DTNASC      AS C_DTNASC                " +
                     " ,C.CEP         AS C_CEP                   " +
                     " ,C.CIDADE      AS C_CIDADE                " +
                     " ,C.UF          AS C_UF                    " +
                     " ,C.BAIRRO      AS C_BAIRRO                " +
                     " ,C.ENDERECO    AS C_ENDERECO              " +
                     " ,C.NUM         AS C_NUM                   " +
                     " ,C.COMPLEMENTO AS C_COMPLEMENTO           " +
                     " ,C.CELULAR     AS C_CELULAR               " +
                     " ,C.TELEFONE    AS C_TELEFONE              " +
                     " ,C.WHATSAPP    AS C_WHATSAPP              " +
                     " ,C.EMAIL       AS C_EMAIL                 " +
                     " ,C.SITE        AS C_SITE                   " +
                     "                           " +
                     " ,I.IDVENDA                " +
                     " ,I.SEQ                    " +
                     " ,I.CODPROD                " +
                     " ,P.DESCRICAO              " +
                     " ,P.CODAUXILIAR            " +
                     " ,P.MEDIDA                 " +
                     " ,P.PCUSTO                 " +
                     " ,P.ESTOQUE                " +
                     " ,P.PVENDA                 " +
                     " ,P.IMG                    " +
                     " ,I.QTDE                   " +
                     " ,I.PCUSTO   AS PCUSTO_UNIT              " +
                     " ,I.PUNIT                  " +
                     " ,I.PDESC                  " +
                     " ,I.PVENDA   AS PVENDA_UNIT   " +
                     " ,I.PTOTAL                 " +
                     "                           " +
                     "                           " +
                     " FROM                      " +
                     "                           " +
                     " TBVENDA          V        " +
                     " ,TBVENDA_ITENS    I       " +
                     " ,TBPRODUTO        P       " +
                     " ,TBFUNCIONARIO    E       " +
                     " ,TBFILIAL         A       " +
                     " ,TBCLIENTE        C       " +
                     "                           " +
                     " WHERE                     " +
                     "                           " +
                     " I.IDVENDA   = V.ID AND    " +
                     " I.CODPROD   = P.ID AND    " +
                     " V.IDFUNC    = E.ID AND    " +
                     " V.IDFILIAL  = A.ID AND    " +
                     " V.IDCLIENTE = C.ID AND    " +
                     " V.ID = " + idVendaCupom;


           
        }
        public void cupomA4()
        {
            
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_ComprovanteVenda_A4.rdlc";
                a.Sql_Relatorio1 = this.sqlCupom;
                a.Dataset_Relatorio1 = "DataSet_Venda";
                a.Dataset_Relatorio2 = "DataSet_Financeiro";
                a.ShowDialog();
        }
        public void cupomNfiscal()
        {

            frm_PDVComprovante a = new frm_PDVComprovante();
            a.Arquivo_rdlc = "Rpv_ComprovanteVenda_Cupom.rdlc";
            a.Sql_Relatorio1 = this.sqlCupom;
            a.Dataset_Relatorio1 = "DataSet_Venda";
            a.Dataset_Relatorio2 = "DataSet_Financeiro";
            a.ShowDialog();
          

        }

    }
}
