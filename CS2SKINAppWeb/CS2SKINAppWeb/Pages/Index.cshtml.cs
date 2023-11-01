using CS2SKINAppWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CS2SKINAppWeb.Pages;

public class IndexModel : PageModel
{
    public IList<Skins> ListaSkins { get; private set; }

    public void OnGet()
    {
        var servico = new SkinsService();
        ListaSkins = servico.ObterTodos();
    }
}