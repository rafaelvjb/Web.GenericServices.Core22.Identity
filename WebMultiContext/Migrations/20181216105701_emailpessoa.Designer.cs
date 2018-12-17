﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMultiContext.AppContext;

namespace WebMultiContext.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181216105701_emailpessoa")]
    partial class emailpessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebMultiContext.AppContext.Email", b =>
                {
                    b.Property<Guid>("EmailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Endereco")
                        .HasMaxLength(250);

                    b.Property<Guid?>("PessoaId");

                    b.HasKey("EmailId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("WebMultiContext.AppContext.Pessoa", b =>
                {
                    b.Property<Guid>("PessoaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Deletado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TelefoneId");

                    b.HasKey("PessoaId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("WebMultiContext.AppContext.Telefone", b =>
                {
                    b.Property<Guid>("TelefoneId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Numero")
                        .HasMaxLength(12);

                    b.HasKey("TelefoneId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("WebMultiContext.AppContext.Email", b =>
                {
                    b.HasOne("WebMultiContext.AppContext.Pessoa")
                        .WithMany("Emails")
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("WebMultiContext.AppContext.Pessoa", b =>
                {
                    b.HasOne("WebMultiContext.AppContext.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
