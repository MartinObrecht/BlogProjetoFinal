namespace BlogProjetoFinal.Data.Repositories
{
    public class BaseRepository
    {
        private readonly BlogProjetoFinalDbContext _dbContext;
        protected BlogProjetoFinalDbContext DbContext => _dbContext;

        public BaseRepository(BlogProjetoFinalDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
