using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ConsoleApp1.Modelos.Usuario", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                b.Property<string>("Apellido")
                    .IsRequired()
                    .HasColumnType("VARCHAR(20)");

                b.Property<string>("Dirección")
                    .IsRequired()
                    .HasColumnType("VARCHAR(20)");

                b.Property<string>("Nombre")
                    .IsRequired()
                    .HasColumnType("VARCHAR(20)");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("VARCHAR(10)");

                b.Property<string>("Telefono")
                    .IsRequired()
                    .HasColumnType("VARCHAR(40)");

                b.Property<string>("fechaDeNacimiento")
                    .IsRequired()
                    .HasColumnType("VARCHAR(10)");

                b.HasKey("Id");

                b.ToTable("Usuarios");
            });
#pragma warning restore 612, 618
        }
    }
}
