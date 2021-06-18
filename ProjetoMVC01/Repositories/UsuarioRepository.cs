using Dapper;
using ProjetoMVC01.Entities;
using ProjetoMVC01.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Usuario Consultar(string email, string senha)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Usuario>("SP_CONSULTARUSUARIO",
                                new { 
                                    @EMAIL = email,
                                    @SENHA = senha
                                },
                                commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void Inserir(Usuario usuario)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("SP_INSERIRUSUARIO",
                            new
                            {
                                @NOME = usuario.Nome,
                                @EMAIL = usuario.Email,
                                @SENHA = usuario.Senha
                            },
                            commandType: CommandType.StoredProcedure);
            }
        }
    }
}
