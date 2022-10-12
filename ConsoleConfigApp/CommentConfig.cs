using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleConfigApp;

public class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comment");
        builder.Property(comment => comment.Id).IsRequired().IsUnicode();
        builder.Property(comment => comment.Expression).HasMaxLength(250);
        builder.HasOne<Article>(comment => comment.Article)
            .WithMany(article => article.Comments).IsRequired();
    }
}