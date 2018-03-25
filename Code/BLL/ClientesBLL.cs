using System;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;
using Projetos3Camadass.Code.DTO;
using Projetos3Camadass.Code.DAL;

namespace Projetos3Camadass.Code.BLL
{
    public class ClientesBLL
    {

        ClientesDAL conexaoDB = new ClientesDAL();

        public void inserirDados(ClientesDTO dto){
            conexaoDB.insertOnDB("insert into tbCliente (nome, email) values (@nome, @email)", dto);
        }

        public void pegarDados(){
            conexaoDB.selectOnDB("select * from tbCliente");
        }

    }
}
