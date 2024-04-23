﻿using Microsoft.EntityFrameworkCore;

namespace mf_pucminas.Modelo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<VeiculoUsuarios>()
                .HasKey(c => new { c.Veiculoid, c.UsuarioId });

            builder.Entity<VeiculoUsuarios>()
                .HasOne(c => c.Veiculo).WithMany(c => c.Usuarios)
                .HasForeignKey(c => c.Veiculoid);
            builder.Entity<VeiculoUsuarios>()
                .HasOne(c => c.Usuario).WithMany(c => c.Veiculos)
                .HasForeignKey(c => c.UsuarioId);
        }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        public DbSet<VeiculoUsuarios> VeiculoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
