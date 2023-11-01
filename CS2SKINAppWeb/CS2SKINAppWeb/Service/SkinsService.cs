using CS2SKINAppWeb.NovaPasta3;

public class SkinsService
{
    public IList<Skins> ObterTodos()
    {
         return new List<Skins>()
         {
                new Skins
                {
                    SkinsID = 1,
                    Nome = "M4A4 | Howl",
                    Raridade = "Contrabandeado",
                    Condicao = "Pouco Usada",
                    Float = "0.09061618",
                    Descricao = "A M4A4 | Howl é uma skin rara e valiosa. Ela apresenta uma arte de um lobo uivando em um fundo preto com detalhes em vermelho e branco. Essa skin se tornou famosa devido a uma história de direitos autorais e sua remoção do mercado do jogo, o que a torna muito procurada por colecionadores e jogadores.",
                    ImagemUri = "/NovaPasta1/M4A4HOWL.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 29498,
                },
                new Skins
                {
                    SkinsID = 2,
                    Nome = "★ Moto Gloves | Spearmint",
                    Raridade = "Extraordinário",
                    Condicao = "Testada em Campo",
                    Float = "0.29783135",
                    Descricao = "Essa skin é conhecida por seu design exclusivo e atraente, que combina cores e padrões inspirados em hortelã, dando a elas uma aparência fresca e estilosa.",
                    ImagemUri = "/NovaPasta1/luvaSpearmint.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 20999,
                },
                new Skins
                {
                    SkinsID = 3,
                    Nome = "AK-47 | Hydroponic",
                    Raridade = "Secreto",
                    Float = "0.05093573",
                    Condicao = "Nova de Frábrica",
                    Descricao = "A Hydroponic é conhecida por seu design único, que geralmente apresenta um padrão de folhas de maconha (cannabis) em tons de verde e preto. O nome Hydroponic é uma referência à técnica de cultivo hidropônico, que é frequentemente usada no cultivo de plantas, incluindo a cannabis.",
                    ImagemUri = "/NovaPasta1/aK-47hydroponic.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 11999,
                },
                new Skins
                {
                    SkinsID = 4,
                    Nome = "★ Karambit | Lore",
                    Raridade = "Oculto",
                    Float = "0.01360608",
                    Condicao = "Nova de Frábrica",
                    Descricao = "A \"Lore\" é famosa por seu tema de design mítico, que geralmente apresenta motivos relacionados à mitologia e lendas. O nome \"Lore\" sugere que a faca está imbuida de histórias e narrativas míticas.",
                    ImagemUri = "/NovaPasta1/Karambitlore.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 19999,
                },
         };

        
    }
    public Skins Obter(int id)
    {
        return ObterTodos().SingleOrDefault(item => item.SkinsID == id);
    }
}
