using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1_C_Sharp_ASP.NET.Pages
{
    public class LivroModel : PageModel
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoDePublicacao { get; set; }
        public double Preco { get; set; }

        public void OnGet()
        {
            Titulo = "O Senhor dos Anéis";
            Autor = "J.R.R. Tolkien";
            AnoDePublicacao = 1954;
            Preco = 79.90;
        }
    }
}

// "O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 79.90