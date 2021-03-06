// <auto-generated />
using System;
using Aluguel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aluguel.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211129181018_alteracaoClasseAluga")]
    partial class alteracaoClasseAluga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aluguel.Models.Consulta.AlugaGrup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cacamba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoCacamba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_aluguel")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_devolucao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeColaborador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdAluga")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AlugaGrup");
                });

            modelBuilder.Entity("Aluguel.Models.Consulta.Itens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_aluguel")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_devolucao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeColaborador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tamanho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Aluga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ColaboradorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_aluguel")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_devolucao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeColaborador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tamanho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ColaboradorID");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Cacamba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tamanho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Caçambas");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Colaborador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("NomeColaborador")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("ID");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Aluga", b =>
                {
                    b.HasOne("Aluguel.Models.Dominio.Cliente", null)
                        .WithMany("Alugueis")
                        .HasForeignKey("ClienteID");

                    b.HasOne("Aluguel.Models.Dominio.Colaborador", null)
                        .WithMany("Alugueis")
                        .HasForeignKey("ColaboradorID");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Cliente", b =>
                {
                    b.Navigation("Alugueis");
                });

            modelBuilder.Entity("Aluguel.Models.Dominio.Colaborador", b =>
                {
                    b.Navigation("Alugueis");
                });
#pragma warning restore 612, 618
        }
    }
}
