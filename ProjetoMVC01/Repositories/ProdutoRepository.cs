using ProjetoMVC01.Entities;
using ProjetoMVC01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using ProjetoMVC01.Models;

namespace ProjetoMVC01.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string _connectionstring;

        public ProdutoRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Alterar(Produto produto)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_ALTERARPRODUTO",
                            new 
                            {
                                @IDPRODUTO = produto.IdProduto,
                                @NOME = produto.Nome,
                                @PRECO = produto.Preco,
                                QUANTIDADE = produto.Quantidade
                            },
                            commandType:CommandType.StoredProcedure);

            }
        }

        public List<Produto> Consultar()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Produto>("SP_CONSULTARPRODUTOS",
                                                commandType:CommandType.StoredProcedure).ToList();
            }
        }

        public void Excluir(Produto produto)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_EXCLUIRPRODUTO",
                            new 
                            {
                                @IDPRODUTO = produto.IdProduto
                            },
                            commandType:CommandType.StoredProcedure);

            }
        }

        public void Insetir(Produto produto)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_INSERIRPRODUTO",
                        new 
                        { 
                            @NOME = produto.Nome,
                            @PRECO = produto.Preco,
                            @Quantidade = produto.Quantidade
                        },
                        commandType:CommandType.StoredProcedure);

            }
        }

        public Produto ObterPorId(Guid idProduto)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Produto>("SP_OBTERPRODUTOPORID",
                                          new 
                                          {
                                              @IDPRODUTO = idProduto
                                          },
                                          commandType:CommandType.StoredProcedure).FirstOrDefault();

            }
        }

        public List<Produto> ConsultarPorDatas(DateTime dataMin, DateTime dataMax)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Produto>("SP_CONSULTARPRODUTOSPORDATA",
                                new
                                {
                                    @DataMin = dataMin,
                                    @DataMax = dataMax
                                },
                                commandType: CommandType.StoredProcedure)
                                .ToList();
            }
        }

        public List<ProdutoGraficoModel> ConsultarTotal()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<ProdutoGraficoModel>("SP_CONSULTARTOTALPRODUTOS",
                                    commandType: CommandType.StoredProcedure)
                                    .ToList();
            }
        }
    }
}
