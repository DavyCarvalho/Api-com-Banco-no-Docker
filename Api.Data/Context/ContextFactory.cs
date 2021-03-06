using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar as migrações
            // var connectionString = "Server=localhost;Port=3306;DataBase=dbAPI;Uid=root;Pwd=0219davy";
            var connectionString = "Data Source=localhost;User Id=sa;PWD=some(!)Password;Initial Catalog=Docker";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            // optionsBuilder.UseMySql (connectionString);
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
