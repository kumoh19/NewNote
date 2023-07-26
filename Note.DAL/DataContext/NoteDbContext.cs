using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Model;

namespace Note.DAL.DataContext
{
    public class NoteDbContext : DbContext  //nuget패키지에서 설치해야함
    {
        private readonly IConfiguration _configuration;

        public NoteDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")); 
            //보안상의 이유로 cs파일에 connection string을 적지않을 것을 권장함 -> appsettngs.json통해 처리
        }
    }
}
