using Microsoft.EntityFrameworkCore;
using Chapter.Models;

namespace Chapter.Contexts

{
    public class ChapterContext : DbContext
    {
        public ChapterContext() 
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options) 
        { 

        }

        // Vamos utilizar esse metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-A0LU46S\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        // db set representa as entidades que serão utilizadas nas operações de leitura, criação, atulização e deleção
        public DbSet<Livro> Livros { get; set; }
    }
}
