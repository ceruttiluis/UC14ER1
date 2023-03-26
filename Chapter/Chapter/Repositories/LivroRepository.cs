using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext chapterContext)
        {
            _context = chapterContext;
        }
        public List<Livro> Listar() 
        { 
            return _context.Livros.ToList();
        }
    }
}
