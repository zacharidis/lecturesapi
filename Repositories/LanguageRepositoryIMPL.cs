using lecturesapi.Data;
using lecturesapi.Models.Domain;

namespace lecturesapi.Repositories
{
    public class LanguageRepositoryIMPL : ILanguageRepository

    {
        private readonly LanguagesDbContext languagesDbContext;

        public LanguageRepositoryIMPL(LanguagesDbContext languagesDbContext)
        {
            this.languagesDbContext = languagesDbContext;
        }
        
        public IEnumerable<Language> GetAll()
        {

            return languagesDbContext.languages.ToList();
        }
    }
}
