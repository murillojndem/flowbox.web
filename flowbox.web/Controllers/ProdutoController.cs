using Dapper;
using flowbox.shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace flowbox.web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ProdutoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            var lista = new List<Produto>();
            using (var conn = new SqlConnection(_configuration.GetConnectionString("AppDbContext")))
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                string sql = "SELECT * FROM dbo.produtos";

                lista = conn.Query<Produto>(sql).ToList();
            }
            return lista;
        }

        [HttpPost]
        public void Post(Produto produto)
        {
            using (var conn = new SqlConnection(_configuration.GetConnectionString("AppDbContext")))
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                string sql = @"INSERT INTO dbo.produtos (Nome, Preco, Quantidade, CodigoDeBarra, ControleDeEstoque) VALUES(@Nome, @Preco, @Quantidade, @CodigoDeBarras, @ControleDeEstoque); ";

                conn.Query<Produto>(sql, new
                {
                    @Nome = produto.Nome,
                    @Preco = produto.Preco,
                    @Quantidade = produto.Quantidade,
                    @CodigoDeBarras = produto.CodigoDeBarra,
                    @ControleDeEstoque = produto.ControleDeEstoque
                });
            }
        }
    }
}
