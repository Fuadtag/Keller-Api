using KellerApi.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace KellerApi.Data
{
    public class KellerDbContext:DbContext
    {
        public KellerDbContext(DbContextOptions<KellerDbContext> options):base(options){
                }
       

        public DbSet<Question> Questions{ get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Company> Companies { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Quest = "Question1",
                    Answer = "Answer1"
                },
                new Question
                {
                    Id = 2,
                    Quest = "Question2",
                    Answer = "Answer2"
                },
                new Question
                {
                    Id = 3,
                    Quest = "Question3",
                    Answer = "Answer3"
                }
                );
        }

        
        
        public DbSet<KellerApi.Data.Entities.Setting> Setting { get; set; }
       

    }
   


}
