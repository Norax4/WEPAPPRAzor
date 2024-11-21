using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEPAPPRAzor.Datos;
using WEPAPPRAzor.Modelos;

namespace WEPAPPRAzor.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _contexto;
        public IndexModel(AppDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Curso> Cursos { get; set; }
        public async Task OnGet()
        {
            Cursos = await _contexto.Cursos.ToListAsync();
        }
    }
}
