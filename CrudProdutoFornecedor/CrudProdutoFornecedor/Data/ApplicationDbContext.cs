using CrudProdutoFornecedor.Models;

using Microsoft.EntityFrameworkCore;



namespace CrudProdutoFornecedor.Data;



public class ApplicationDbContext : DbContext

{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

        : base(options)

    {

    }



    public DbSet<Fornecedor> Fornecedores { get; set; }

    public DbSet<Produto> Produtos { get; set; }

}