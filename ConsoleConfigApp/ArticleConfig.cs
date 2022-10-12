using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleConfigApp;

public class ArticleConfig:IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable("Article").HasKey(article => article.Id);
        builder.Property(article => article.Id).IsRequired().IsUnicode();
        builder.Property(article => article.Title).HasMaxLength(250);
        
    }
}