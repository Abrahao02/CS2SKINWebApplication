using CS2SKINAppWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CS2SKINAppWeb.Pages
{
    public class ComprarModel : PageModel
    {
        public Skins SKIN { get; private set; }  
        public void OnGet(int id)
        {
            var servico = new SkinsService();
            SKIN = servico.Obter(id);
        }
    }
}
