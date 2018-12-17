namespace NewsTable
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("name=News")
        {
        }

        public DbSet<New> NewT { set; get; }

        public DbSet<Comment> CommentT { set; get; }

    }
   
}