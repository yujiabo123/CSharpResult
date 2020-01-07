namespace Y_DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationTest")
        {
        }

        public virtual DbSet<AccountInfo> AccountInfoes { get; set; }
        public virtual DbSet<VertifyRecord> VertifyRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.MachineId)
                .IsFixedLength();

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.QQ)
                .IsFixedLength();

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.WeChat)
                .IsFixedLength();

            modelBuilder.Entity<AccountInfo>()
                .Property(e => e.WeiBo)
                .IsFixedLength();

            modelBuilder.Entity<VertifyRecord>()
                .Property(e => e.VertifyCode)
                .IsFixedLength();
        }
    }
}
