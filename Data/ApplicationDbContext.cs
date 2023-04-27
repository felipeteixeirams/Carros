using Carros.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Carros.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            : base(options)
        {
        }

        public DbSet<ConsumoCombustivel> ConsumoCombustivel { get; set; }
    }
}