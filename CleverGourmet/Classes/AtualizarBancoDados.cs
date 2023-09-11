using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverSoft
{
  public class AtualizarBancoDados
    {

        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr = "";
        string atulizarVersao = "";
        public int versaoSistema;
        
        public void atualizar()
        {
            conexao.Abre_Conexao();
            try
            {
                if (versaoSistema <= 0)
                {
                    SQLCunsultaEmpr =
                      " DROP TABLE IF EXISTS TBVERSAO; " +
                      " CREATE TABLE TBVERSAO (ID INTEGER PRIMARY KEY AUTOINCREMENT, VERSAO VARCHAR(5));" +
                      " INSERT INTO TBVERSAO (ID, VERSAO) VALUES(1, 0);";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();
                    versaoSistema += 1;
                } //CRIA A TABLE VERSÃO

                if (versaoSistema <= 1)
                {
                    SQLCunsultaEmpr =
                     " DROP TABLE IF EXISTS TBPERMISSAO; " +
                     " CREATE TABLE TBPERMISSAO (ID INTEGER PRIMARY KEY AUTOINCREMENT, IDFUNC INTEGER, NOMEROTINA VARCHAR(45));";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();
                    versaoSistema += 1;
                } //CRIA A TABLE PERMISSÃO

                if (versaoSistema <= 2)
                {
                    SQLCunsultaEmpr =
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'PERMISSÃO');               " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'PRODUTO');                 " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CLIENTE');                 " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'PERMISSÃO');               " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'PRODUTO');                 " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CLIENTE');                 " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'FORNECEDOR');              " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'FUNCIONÁRIO');             " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'EMPRESA');                 " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'DEPARTAMENTO');            " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'SEÇÃO');                  " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'PERMISSÃO');              " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CONSULTAR PRODUTO');      " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'ENTRADA DE MERCADORIA');  " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'HISTORICO DE COMPRAS');   " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'BANCO E CONTA');          " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'MOEDA');                  " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'COBRANÇA');               " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'GRUPO CONTA GERENCIAL');  " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CONTA GERENCIAL');        " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CONTAS A PAGAR');         " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CONTAS A RECEBER');       " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'TELA DE VENDAS (PDV)');   " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'HISTORICO DE VENDAS');    " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'CONFIGURAÇÃO');           " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'ATUALIZAÇÃO');            " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'BACKUP');                 " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'SUPORTE');                " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'LICENÇA');                " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'Troca de usuário');       " +
                       " INSERT INTO TBPERMISSAO(IDFUNC, NOMEROTINA) VALUES(1, 'Sair');                   ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();
                    versaoSistema += 1;
                } //INSERIR OS DADOS NA TABLE PERMISSAO

                if (versaoSistema <= 3)
                {
                    SQLCunsultaEmpr =
                    " DELETE FROM TBCP WHERE DTLANC <= '17/03/2021'; " +
                    " DELETE FROM TBCR WHERE DTLANC <= '17/03/2021'; ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();
                    versaoSistema += 1;
                } // LIMPA OS REGISTROS FINACEIROS

                if (versaoSistema <= 4)
                {
                    SQLCunsultaEmpr =
                    " CREATE TABLE TBCP_EX(" +
                    " ID               INTEGER       PRIMARY KEY AUTOINCREMENT" +
                    "                                NOT NULL,                " +
                    " TIPO             VARCHAR(45),                           " +
                    " IDFILIAL         INTEGER,                               " +
                    " IDPARCEIRO       INTEGER,                               " +
                    " IDMOEDA          INTEGER,                               " +
                    " IDCONTA          INTEGER,                               " +
                    " IDCONTAGERENCIAL INTEGER,                               " +
                    " HISTORICO        VARCHAR(200),                          " +
                    " NUMDOC           VARCHAR(45),                           " +
                    " DTLANC           VARCHAR(45),                           " +
                    " DTVENC           VARCHAR(45),                           " +
                    " DTCOMPETENCIA    VARCHAR(45)  DEFAULT now,              " +
                    " DTPGTO           VARCHAR(45),                           " +
                    " VALOR            VARCHAR(45),                           " +
                    " VLRDESC          VARCHAR(45),                           " +
                    " VLRJUROS         VARCHAR(45),                           " +
                    " VLRTOTAL         VARCHAR(45),                           " +
                    " VLREXTENSO       VARCHAR(200),                          " +
                    " IDVENDA          VARCHAR(20),                           " +
                    " STATUS           VARCHAR(45));                          ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    SQLCunsultaEmpr =
                    " CREATE TABLE TBCR_EX(" +
                    " ID               INTEGER       PRIMARY KEY AUTOINCREMENT" +
                    "                                NOT NULL,                " +
                    " TIPO             VARCHAR(45),                           " +
                    " IDFILIAL         INTEGER,                               " +
                    " IDPARCEIRO       INTEGER,                               " +
                    " IDMOEDA          INTEGER,                               " +
                    " IDCONTA          INTEGER,                               " +
                    " IDCONTAGERENCIAL INTEGER,                               " +
                    " HISTORICO        VARCHAR(200),                          " +
                    " NUMDOC           VARCHAR(45),                           " +
                    " DTLANC           VARCHAR(45),                           " +
                    " DTVENC           VARCHAR(45),                           " +
                    " DTCOMPETENCIA    VARCHAR(45)  DEFAULT now,              " +
                    " DTPGTO           VARCHAR(45),                           " +
                    " VALOR            VARCHAR(45),                           " +
                    " VLRDESC          VARCHAR(45),                           " +
                    " VLRJUROS         VARCHAR(45),                           " +
                    " VLRTOTAL         VARCHAR(45),                           " +
                    " VLREXTENSO       VARCHAR(200),                          " +
                    " IDVENDA          VARCHAR(20),                           " +
                    " STATUS           VARCHAR(45));                          ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();



                    SQLCunsultaEmpr = "UPDATE TBCONTAGERENCIAL SET CONTAGERENCIAL = 'TRANSFERÊNCIA', IDGRUPO = '2' WHERE ID = 2";
                   
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    versaoSistema += 1;
                } // CRIA AS TABLE TBCP_EX E TBCR_EX

                if (versaoSistema <= 5) //CRIA CAMPO EXCLUSIVO CODIGOA AUXILIAR
                {
                    SQLCunsultaEmpr =
                 "  PRAGMA foreign_keys = 0;                                                                      " +
                 "                                                                                                " +
                 "   CREATE TABLE sqlitestudio_temp_table AS SELECT*                                              " +
                 "                                             FROM TBPRODUTO;                                    " +
                 "                                                                                                " +
                 "   DROP TABLE TBPRODUTO;                                                                        " +
                 "                                                                                                " +
                 "   CREATE TABLE TBPRODUTO(                                                                      " +
                 "       ID          INTEGER       PRIMARY KEY AUTOINCREMENT                                      " +
                 "                                                                                                " +
                 "                                                                                                " +
                 "                                 NOT NULL,                                                      " +
                 "       DESCRICAO   VARCHAR(45),                                                                 " +
                 "       CODAUXILIAR VARCHAR(45)  CONSTRAINT[Já existem um item com esse codigo auxiliar] UNIQUE, " +
                 "       MEDIDA      VARCHAR(45),                                                                 " +
                 "       PCUSTO      VARCHAR(45),                                                                 " +
                 "       ESTOQUE     VARCHAR(45),                                                                 " +
                 "       PVENDA      VARCHAR(45),                                                                 " +
                 "       DTEXCLUSAO  DATE,                                                                        " +
                 "       IMG         VARCHAR(200),                                                                " +
                 "       IDSECAO     INTEGER                                                                      " +
                 "   );                                                                                           " +
                 "                                                                                                " +
                 "   INSERT INTO TBPRODUTO(                                                                       " +
                 "                             ID,                                                                " +
                 "                             DESCRICAO,                                                         " +
                 "                             CODAUXILIAR,                                                       " +
                 "                             MEDIDA,                                                            " +
                 "                             PCUSTO,                                                            " +
                 "                             ESTOQUE,                                                           " +
                 "                             PVENDA,                                                            " +
                 "                             DTEXCLUSAO,                                                        " +
                 "                             IMG,                                                               " +
                 "                             IDSECAO                                                            " +
                 "                         )                                                                      " +
                 "     SELECT ID,                                                                                 " +
                 "            DESCRICAO,                                                                          " +
                 "            CODAUXILIAR,                                                                        " +
                 "            MEDIDA,                                                                             " +
                 "            PCUSTO,                                                                             " +
                 "            ESTOQUE,                                                                            " +
                 "            PVENDA,                                                                             " +
                 "            DTEXCLUSAO,                                                                         " +
                 "            IMG,                                                                                " +
                 "            IDSECAO                                                                             " +
                 "       FROM sqlitestudio_temp_table;                                                            " +
                 "                                                                                                " +
                 "   DROP TABLE sqlitestudio_temp_table;                                                          " +
                 "                                                                                                " +
                 "   PRAGMA foreign_keys = 1;                                                                     ";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    versaoSistema += 1;
                } //CRIA CAMPO EXCLUSIVO CODIGOA AUXILIAR

                if (versaoSistema <= 6) //CRIA CAMPO TIPO, OBS E NS NA TBPRODUTO
                {
                    SQLCunsultaEmpr =
                "    PRAGMA foreign_keys = 0;                                                                     " +
                "                                                                                                 " +
                "    CREATE TABLE sqlitestudio_temp_table AS SELECT*                                              " +
                "                                              FROM TBPRODUTO;                                    " +
                "                                                                                                 " +
                "    DROP TABLE TBPRODUTO;                                                                        " +
                "                                                                                                 " +
                "    CREATE TABLE TBPRODUTO(                                                                      " +
                "        ID          INTEGER       PRIMARY KEY AUTOINCREMENT                                      " +
                "                                                                                                 " +
                "                                  NOT NULL,                                                      " +
                "        DESCRICAO   VARCHAR(45),                                                                 " +
                "        CODAUXILIAR VARCHAR(45)  CONSTRAINT[Já existem um item com esse codigo auxiliar] UNIQUE, " +
                "        MEDIDA      VARCHAR(45),                                                                 " +
                "        PCUSTO      VARCHAR(45),                                                                 " +
                "        ESTOQUE     VARCHAR(45),                                                                 " +
                "        PVENDA      VARCHAR(45),                                                                 " +
                "        DTEXCLUSAO  DATE,                                                                        " +
                "        IMG         VARCHAR(200),                                                                " +
                "        IDSECAO     INTEGER,                                                                     " +
                "        TIPO        VARCHAR(45),                                                                 " +
                "        NS          VARCHAR(45),                                                                 " +
                "        OBS         VARCHAR(500)                                                                 " +
                "    );                                                                                           " +
                "                                                                                                 " +
                "    INSERT INTO TBPRODUTO(                                                                       " +
                "                              ID,                                                                " +
                "                              DESCRICAO,                                                         " +
                "                              CODAUXILIAR,                                                       " +
                "                              MEDIDA,                                                            " +
                "                              PCUSTO,                                                            " +
                "                              ESTOQUE,                                                           " +
                "                              PVENDA,                                                            " +
                "                              DTEXCLUSAO,                                                        " +
                "                              IMG,                                                               " +
                "                              IDSECAO                                                            " +
                "                          )                                                                      " +
                "          SELECT ID,                                                                             " +
                "                 DESCRICAO,                                                                      " +
                "                 CODAUXILIAR,                                                                    " +
                "                 MEDIDA,                                                                         " +
                "                 PCUSTO,                                                                         " +
                "                 ESTOQUE,                                                                        " +
                "                 PVENDA,                                                                         " +
                "                 DTEXCLUSAO,                                                                     " +
                "                 IMG,                                                                            " +
                "                 IDSECAO                                                                         " +
                "            FROM sqlitestudio_temp_table;                                                        " +
                "                                                                                                 " +
                "    DROP TABLE sqlitestudio_temp_table;                                                          " +
                "                                                                                                 " +
                "    PRAGMA foreign_keys = 1;                                                                     ";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    versaoSistema += 1;
                } //CRIA CAMPO TIPO, OBS E NS NA TBPRODUTO

                if (versaoSistema <= 7) //CRIA CAMPO CODFAB NA TBPRODUTO
                {
                    SQLCunsultaEmpr = "ALTER TABLE TBPRODUTO ADD CODFAB VARCHAR(45);";
               

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    versaoSistema += 1;
                } //CRIA CAMPO CODFAB NA TBPRODUTO

                if (versaoSistema <= 8) //CRIA CAMPO PREST NA TBCR E TBCP
                {
                    SQLCunsultaEmpr = "ALTER TABLE TBCR ADD PREST VARCHAR(5);";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    SQLCunsultaEmpr = "ALTER TABLE TBCR ADD IDCOBRANCA INTEGER;";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();


                    SQLCunsultaEmpr = "ALTER TABLE TBCP ADD PREST VARCHAR(5);";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();


                    SQLCunsultaEmpr = "ALTER TABLE TBCP_EX ADD PREST VARCHAR(5);";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();



                    SQLCunsultaEmpr = "ALTER TABLE TBCR_EX ADD PREST VARCHAR(5);";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();


                    SQLCunsultaEmpr = "ALTER TABLE TBCR_EX ADD IDCOBRANCA INTEGER;";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();


                    SQLCunsultaEmpr = "ALTER TABLE TBVENDA ADD IDCAIXA INTEGER";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    SQLCunsultaEmpr = 
                    " CREATE TABLE TBCAIXA(                                " +
                    " ID         INTEGER      PRIMARY KEY AUTOINCREMENT,   " +
                    " DATA       DATE,                                     " +
                    " IDFUNC     INTEGER,                                  " +
                    " SUPRIMENTO VARCHAR(45),                              " +
                    " STATUS     VARCHAR(45)                               " +
                    " );                                                   ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    versaoSistema += 1;
                } //CRIA CAMPO CODFAB NA TBPRODUTO

                if (versaoSistema <= 9) //CRIA A FUNÇÃO ORCAMENTO
                {


                    SQLCunsultaEmpr = 
                    " CREATE TABLE TBORC                              " +
                    " (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    " IDFILIAL INTEGER DEFAULT (1),                   " +
                    " DATA VARCHAR (45),                              " +
                    " HORA VARCHAR (45),                              " +
                    " IDFUNC INTEGER,                                 " +
                    " IDCLIENTE INTEGER,                              " +
                    " IDMESA INTEGER,                                 " +
                    " VLRORIGINAL VARCHAR (45),                       " +
                    " VLRDESC VARCHAR (45),                           " +
                    " VLRPAGO VARCHAR (45),                           " +
                    " VLRVENDA VARCHAR (45),                          " +
                    " VLRTROCO VARCHAR (45),                          " +
                    " STATUS VARCHAR (45),                            " +
                    " HISTORICO VARCHAR (100),                        " +
                    " IDCAIXA INTEGER);                               ";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();


                    SQLCunsultaEmpr =
                   " CREATE TABLE TBORC_ITENS                      " +
                    " (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    " IDVENDA INTEGER,                                " +
                    " SEQ INTEGER,                                    " +
                    " CODPROD INTEGER,                                " +
                    " QTDE INTEGER,                                   " +
                    " PCUSTO VARCHAR (45),                            " +
                    " PUNIT VARCHAR (45),                             " +
                    " PDESC VARCHAR (45),                             " +
                    " PVENDA VARCHAR (45),                            " +
                    " PTOTAL VARCHAR (45),                            " +
                    " TOTALDESC VARCHAR (45));                        ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();


                    SQLCunsultaEmpr =
                    " CREATE TABLE TBORC_PREST                        " +
                    " (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    " TIPO VARCHAR (45),                              " +
                    " IDFILIAL INTEGER,                               " +
                    " IDPARCEIRO INTEGER,                             " +
                    " IDMOEDA INTEGER,                                " +
                    " IDCONTA INTEGER,                                " +
                    " IDCONTAGERENCIAL INTEGER,                       " +
                    " HISTORICO VARCHAR (100),                        " +
                    " NUMDOC VARCHAR (45),                            " +
                    " DTLANC VARCHAR (45),                            " +
                    " DTVENC VARCHAR (45),                            " +
                    " DTCOMPETENCIA VARCHAR (45),                     " +
                    " DTPGTO VARCHAR (45),                            " +
                    " VALOR VARCHAR (45),                             " +
                    " VLRDESC VARCHAR (45),                           " +
                    " VLRJUROS VARCHAR (45),                          " +
                    " VLRTOTAL VARCHAR (45),                          " +
                    " VLREXTENSO VARCHAR (200),                       " +
                    " IDVENDA VARCHAR (20),                           " +
                    " STATUS VARCHAR (45),                            " +
                    " PREST VARCHAR(5));                              ";
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    versaoSistema += 1;
                } //CRIA CAMPO CODFAB NA TBPRODUTO
             
                if (versaoSistema <= 10) //CRIA A FUNÇÃO ORCAMENTO
                {


                    SQLCunsultaEmpr =
                   "  CREATE TABLE TBPRODMOV(                       " +
                   "  ID INTEGER       PRIMARY KEY AUTOINCREMENT,   " +
                   "  DTMOV DATE,                                   " +
                   "  CODPROD INTEGER,                              " +
                   "  QTDE VARCHAR (45),                            " +
                   "  TIPOMOV VARCHAR(45),                          " +
                   "  MOTIVO VARCHAR(100)                           " +
                   " );                                             ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                 
                    versaoSistema += 1;
                } //CRIA TBPRODMOV


                atulizarVersao =
                "UPDATE TBVERSAO SET VERSAO = " + versaoSistema;
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = atulizarVersao;
                conexao.cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {
               
            }
            conexao.Fecha_Conexao();


        }
    }
}
