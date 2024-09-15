using LivrariaMVC.Models;
using Microsoft.EntityFrameworkCore;
using LivrariaMVC.Models;

namespace LivrariaMVC.Data
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}