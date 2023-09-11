using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverSoft
{
    class relatorioCompras
    {
        public int idVendaCupom;
        string sqlCupom;
        public void gerarRelatorio()
        {
            sqlCupom  = " SELECT                   " +
                            " P.ID,                  " +
                            " P.IDFUNC,              " +
                            " E.NOME,                " +
                            " F.DTEXCLUSAO,          " +
                            " P.DTLANC,              " +
                            " P.HISTORICO,           " +
                            " P.STATUS,              " +
                            " --fornecedor--         " +
                            " P.IDFORNEC,            " +
                            " F.RAZAOSOCIAL,         " +
                            " F.FANTASIA,            " +
                            " F.TIPOPESSOA,          " +
                            " F.CNPJ_CPF,            " +
                            " F.IE_RG,               " +
                            " F.DTNASC,              " +
                            " F.CEP,                 " +
                            " F.CIDADE,              " +
                            " F.UF,                  " +
                            " F.BAIRRO,              " +
                            " F.ENDERECO,            " +
                            " F.NUM,                 " +
                            " F.COMPLEMENTO,         " +
                            " F.CELULAR,             " +
                            " F.TELEFONE,            " +
                            " F.WHATSAPP,            " +
                            " F.EMAIL,               " +
                            " F.SITE,                " +
                            " F.OBS,                 " +
                            " I.IDPEDIDO,            " +
                            " I.SEQ,                 " +
                            " I.CODPROD,             " +
                            " I.QTDE,                " +
                            " I.PCUSTO,              " +
                            " I.IPI,                 " +
                            " I.OUTROCUSTO,          " +
                            " I.DESCONTO,            " +
                            " I.TOTALUNT,            " +
                            " I.TOTAL                " +
                            "   FROM                 " +
                            " TBPEDIDO P,            " +
                            " TBFORNECEDOR F,        " +
                            " TBFUNCIONARIO E,       " +
                            " TBPEDIDO_ITENS I       " +
                            " WHERE                  " +
                            " I.IDPEDIDO = P.ID AND  " +
                            " P.IDFUNC = E.ID  AND   " +
                            " P.IDFORNEC = F.ID      ";

        }
        public void relatorio()
        {

            frm_Relatorio a = new frm_Relatorio();
            a.Arquivo_rdlc = "Rpv_ComprovanteVenda_A4.rdlc";
            a.Sql_Relatorio1 = this.sqlCupom;
            a.Dataset_Relatorio1 = "DataSet_Venda";
            a.Dataset_Relatorio2 = "DataSet_Financeiro";
            a.ShowDialog();
        }
    }
}
