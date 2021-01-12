using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using SocialMedia.Core.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SocialMedia.Infrastucture.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Publicacion");

            builder.HasKey(e => e.PostId);
            
            builder.Property(e => e.PostId)
              .HasColumnName("IdPublicacion");

            builder.Property(e => e.UserId)
             .HasColumnName("IdUsuario");

          

            builder.Property(e => e.Description)
                .HasColumnName("Descripcion")
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.Date)
                .HasColumnName("Fecha")
                .HasColumnType("datetime");

            builder.Property(e => e.Image)
                .HasColumnName("Imagen")
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.HasOne(d => d.User)
                .WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publicacion_Usuario");
        }
    }
}
