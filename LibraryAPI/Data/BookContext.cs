using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book[]
            {
                new(){Id=1, Name="Suc ve Ceza", Author="Dostoyevski", pageSize=560, Price=45, Type="Roman"},
                new(){Id=2, Name="Tekvin", Author="Arif Ergin", pageSize=760, Price=56, Type="Roman"},
                new(){Id=3, Name="Cin Ali", Author="Ali", pageSize=870, Price=10, Type="Çocuk"},
                new(){Id=4, Name="Yüzüklerin Efendisi", Author="JR:R TOLKIEN", pageSize=900, Price=90, Type="Bilim Kurgu"},
                new(){Id=5, Name="Sineklerin Tanrısı", Author="William Golding", pageSize=340, Price=25, Type="Roman"},
                new(){Id=6, Name="Cesur Yeni Dunya", Author="Aldous Huxley", pageSize=490, Price=60, Type="Felsefe"},
                new(){Id=7, Name="Kinyas ve Kayra", Author="Hakan Günday", pageSize=652, Price=60, Type="Roman"}
            });
        }
        public DbSet<Book> Books { get; set; }
    }
}
