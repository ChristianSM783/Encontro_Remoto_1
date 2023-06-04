using Chapter16._1.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter16._1.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(){}
        public SqlContext(DbContextOptions<SqlContext> options) : base(options){}
        protected override void 
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação;
                // optionsBuilder.UseSqlServer("Data Source = DESKTOP-MNPOEP2\\SQLEXPRESS2022; initial catalog = Chapter16; user id = sa; password = 16202003");
                // optionsBuilder.UseSqlServer("Data Source = DESKTOP-MNPOEP2\\SQLEXPRESS2022; initial catalog = Chapter16; Integrated Security = ture; TrustServerCertificate=True");
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-MNPOEP2\\SQLEXPRESS2022; initial catalog = Chapter16; Integrated Security = true");
            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
