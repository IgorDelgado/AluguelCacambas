using Aluguel.Models.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Mapeamento
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {

        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {

            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.NomeColaborador).HasMaxLength(35).IsRequired();
            builder.Property(p => p.Funcao).HasMaxLength(35).IsRequired();

            builder.ToTable("Colaborador");
        }
    }
}