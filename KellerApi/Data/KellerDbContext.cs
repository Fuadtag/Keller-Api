using KellerApi.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace KellerApi.Data
{
    public class KellerDbContext:DbContext
    {
        public KellerDbContext(DbContextOptions<KellerDbContext> options):base(options)
        {
        }
        public DbSet<Question> Questions{ get; set; }







        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Quest = "Q. Dummy text lorem ipsum dolor sit amet",
                    Answer = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa culpa ea suscipit animi, reprehenderit incidunt nostrum voluptas, nihil ipsum quaerat, dolore magni veritatis aliquid? Illo delectus eligendi ullam nobis sint ad possimus! Expedita id asperiores veniam sunt dolores corrupti, quam odit blanditiis est enim distinctio quidem ut dignissimos, vel harum?"
                },
                new Question
                {
                    Id = 2,
                    Quest = "Q. Dummy text lorem ipsum dolor sit amet",
                    Answer = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa culpa ea suscipit animi, reprehenderit incidunt nostrum voluptas, nihil ipsum quaerat, dolore magni veritatis aliquid? Illo delectus eligendi ullam nobis sint ad possimus! Expedita id asperiores veniam sunt dolores corrupti, quam odit blanditiis est enim distinctio quidem ut dignissimos, vel harum?"
                }


                );
    }

    }
   
}
