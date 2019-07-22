using ddd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ddd.Infra.Data.Mapping
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Task");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasColumnName("Titulo");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnName("Descricao");

            builder.Property(c => c.DataCriacao)
                .HasColumnName("DataCriacao");

            builder.Property(c => c.DataEdicao)
                .HasColumnName("DataEdicao");

            builder.Property(c => c.DataExclusao)
                .HasColumnName("DataExclusao");

            builder.Property(c => c.DataConclusao)
                .HasColumnName("DataConclusao");

            builder.Property(c => c.TaskConcluida)
                .HasDefaultValue(false)
                .HasColumnName("TaskConcluida");

            builder.Property(c => c.TaskExcluida)
                .HasDefaultValue(false)
                .HasColumnName("TaskExcluida");
        }
    }
}