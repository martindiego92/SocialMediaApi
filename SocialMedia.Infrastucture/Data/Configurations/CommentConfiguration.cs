using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Infrastucture.Data.Configurations
{
    class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comentario");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("IdComentario")
            .ValueGeneratedNever();

            builder.Property(e => e.PostId).HasColumnName("IdPublicacion")
          .ValueGeneratedNever();

            builder.Property(e => e.IsActice).HasColumnName("Activo")
          .ValueGeneratedNever();



            builder.Property(e => e.Description).HasColumnName("Descripcion")
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.Date).HasColumnName("Fecha")
            .HasColumnType("datetime");

            builder.HasOne(d => d.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentario_Publicacion");

            builder.HasOne(d => d.User)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentario_Usuario");
        }
    }
}
