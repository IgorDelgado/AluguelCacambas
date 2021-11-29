using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aluguel.Models.Dominio;

namespace Aluguel.Models.Mapeamento
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.NomeCliente).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Endereco).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Municipio).HasMaxLength(25).IsRequired();
           
            builder.Property(p => p.Email).HasMaxLength(35).IsRequired();
            builder.Property(p => p.CPF).HasMaxLength(14).IsRequired();
            builder.HasIndex(p => p.CPF).IsUnique();


            builder.ToTable("Clientes");
        }

        
    }
}
