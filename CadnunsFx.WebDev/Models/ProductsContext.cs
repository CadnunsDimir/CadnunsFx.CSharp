using System.Data.Entity;

namespace CadnunsFx.WebDev.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("ProdutosTeste")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}