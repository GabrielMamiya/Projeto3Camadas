using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using Projetos3Camadass.Code.DTO;

namespace Projetos3Camadass.Code.DAL
{
    public class ClientesDAL
    {

        protected static MySqlConnection conn = new MySqlConnection();


        public void insertOnDB(string query, ClientesDTO dto)
        {
            conn.ConnectionString = Conexao.cn;

            try{
                conn.Open();
				try
				{
					conn.Execute(query, new {nome = dto.nome, email = dto.email});
					Console.WriteLine("Dados inseridos com sucesso!");
				}
				catch (Exception e)
				{
					Console.WriteLine("Erro ao inserir dados: " + e.Message);
				}
            }
            catch(Exception e){
                Console.WriteLine("Erro ao abrir o banco: " + e.Message);
            }
            finally{
                if(conn.State == ConnectionState.Open){
                    conn.Close();
                }
            }
        }

        public void selectOnDB(string query){
            conn.ConnectionString = Conexao.cn;
            try {
                conn.Open();
                try{
                    List<ClientesDTO> listaDeClientes = conn.Query<ClientesDTO>(query).ToList();
                    listaDeClientes.ForEach((item) =>
                    {
                        Console.WriteLine(item.nome);
                        Console.WriteLine(item.email);
                    });
                }
                catch(Exception e){
                    Console.WriteLine("Erro ao selecionar lista: " + e.Message);
                }
            }
            catch (Exception e){
                Console.WriteLine("Erro ao conectar no banco: " + e.Message);
            }
        }


    }
}
