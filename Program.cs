using System;
using MySql.Data.MySqlClient;
using Projetos3Camadass.Code.BLL;
using Projetos3Camadass.Code.DTO;

namespace Projetos3Camadass
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ClientesDTO dto = new ClientesDTO() { nome = "Gabriel Tamura Mamiya", email = "gabriel-tamura@hotmail.com"};
            ClientesBLL bll = new ClientesBLL();

            //bll.inserirDados(dto);
            bll.pegarDados();
        }
    }
}
