using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Aluno> Aluno { get; set; }

        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno");

            modelBuilder.Entity<Aluno>()
                .HasOne(e => e.Turma)
                .WithMany(e => e.Aluno)
                .HasForeignKey(e => e.TurmaId);

        }
    }


}
