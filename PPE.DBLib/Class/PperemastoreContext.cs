using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PPE.DBLib.Class;

public partial class PperemastoreContext : DbContext
{
    public PperemastoreContext()
    {
    }

    public PperemastoreContext(DbContextOptions<PperemastoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Baie> Baies { get; set; }

    public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; }

    public virtual DbSet<MessengerMessage> MessengerMessages { get; set; }

    public virtual DbSet<Pack> Packs { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Unite> Unites { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=PPEremastore;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__baie__3213E83FA1C10F58");

            entity.ToTable("baie");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NbSpot).HasColumnName("nb_spot");
        });

        modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK__doctrine__79B5C94CF66C0996");

            entity.ToTable("doctrine_migration_versions");

            entity.Property(e => e.Version)
                .HasMaxLength(191)
                .HasColumnName("version");
            entity.Property(e => e.ExecutedAt)
                .HasPrecision(6)
                .HasColumnName("executed_at");
            entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");
        });

        modelBuilder.Entity<MessengerMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__messenge__3213E83F872ED776");

            entity.ToTable("messenger_messages");

            entity.HasIndex(e => e.DeliveredAt, "IDX_75EA56E016BA31DB");

            entity.HasIndex(e => e.AvailableAt, "IDX_75EA56E0E3BD61CE");

            entity.HasIndex(e => e.QueueName, "IDX_75EA56E0FB7336F0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AvailableAt)
                .HasPrecision(6)
                .HasComment("(DC2Type:datetime_immutable)")
                .HasColumnName("available_at");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(6)
                .HasComment("(DC2Type:datetime_immutable)")
                .HasColumnName("created_at");
            entity.Property(e => e.DeliveredAt)
                .HasPrecision(6)
                .HasComment("(DC2Type:datetime_immutable)")
                .HasColumnName("delivered_at");
            entity.Property(e => e.Headers)
                .IsUnicode(false)
                .HasColumnName("headers");
            entity.Property(e => e.QueueName)
                .HasMaxLength(190)
                .HasColumnName("queue_name");
        });

        modelBuilder.Entity<Pack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pack__3213E83F274208CC");

            entity.ToTable("pack");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NbSlot).HasColumnName("nb_slot");
            entity.Property(e => e.PicturePath)
                .HasMaxLength(255)
                .HasColumnName("picture_path");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__reservat__3213E83F1D07FFD0");

            entity.ToTable("reservation");

            entity.HasIndex(e => e.PackId, "IDX_42C849551919B217");

            entity.HasIndex(e => e.CustomerId, "IDX_42C849559395C3F3");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.DateEnd)
                .HasColumnType("date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasColumnType("date")
                .HasColumnName("date_start");
            entity.Property(e => e.PackId).HasColumnName("pack_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Renew).HasColumnName("renew");

            entity.HasOne(d => d.Customer).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_42C849559395C3F3");

            entity.HasOne(d => d.Pack).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.PackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_42C849551919B217");
        });

        modelBuilder.Entity<Unite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__unite__3213E83FDCB8711B");

            entity.ToTable("unite");

            entity.HasIndex(e => e.BaieIdId, "IDX_1D64C1182F142266");

            entity.HasIndex(e => e.ReservationIdId, "IDX_1D64C1183C3B4EF0");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaieIdId).HasColumnName("baie_id_id");
            entity.Property(e => e.NameSpot).HasColumnName("name_spot");
            entity.Property(e => e.ReservationIdId).HasColumnName("reservation_id_id");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.BaieId).WithMany(p => p.Unites)
                .HasForeignKey(d => d.BaieIdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1D64C1182F142266");

            entity.HasOne(d => d.ReservationId).WithMany(p => p.Unites)
                .HasForeignKey(d => d.ReservationIdId)
                .HasConstraintName("FK_1D64C1183C3B4EF0");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user__3213E83F5DDABE7D");

            entity.ToTable("user");

            entity.HasIndex(e => e.Email, "UNIQ_8D93D649E7927C74")
                .IsUnique()
                .HasFilter("([email] IS NOT NULL)");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addresse)
                .HasMaxLength(255)
                .HasColumnName("addresse");
            entity.Property(e => e.Email)
                .HasMaxLength(180)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Roles)
                .IsUnicode(false)
                .HasComment("(DC2Type:json)")
                .HasColumnName("roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
