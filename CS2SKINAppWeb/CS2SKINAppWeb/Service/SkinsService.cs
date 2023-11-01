﻿using CS2SKINAppWeb.NovaPasta3;

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
                    Pattern = 74,
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
                    Pattern = 34,
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
                    Pattern = 107,
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
                    Pattern = 304,
                    Descricao = "A \"Lore\" é famosa por seu tema de design mítico, que geralmente apresenta motivos relacionados à mitologia e lendas. O nome \"Lore\" sugere que a faca está imbuida de histórias e narrativas míticas.",
                    ImagemUri = "/NovaPasta1/Karambitlore.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 19999,
                },
                new Skins
                {
                    SkinsID = 5,
                    Nome = "StatTrak™ M4A1-S | Hyper Beast",
                    Raridade = "Oculto",
                    Float = "0.06704647",
                    Condicao = "Nova de Frábrica",
                    Pattern = 840,
                    Descricao = "Explore o lado feroz do Counter-Strike com a StatTrak™ M4A1-S | Hyper Beast! Esta deslumbrante skin oferece um design vibrante e agressivo inspirado nas feras mais temíveis da natureza. Cada eliminação que você alcançar com esta beleza será gravada em sua coleção pessoal, tornando-a uma adição exclusiva e memorável ao seu arsenal.",
                    ImagemUri = "/NovaPasta1/hyperbeast.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 19999,
                },
                new Skins
                {
                    SkinsID = 6,
                    Nome = "AWP | Medusa",
                    Raridade = "Oculto",
                    Float = "0.39287701",
                    Condicao = "Bem Desgatada",
                    Pattern = 534,
                    Descricao = "Apresentamos a lendária AWP | Medusa, uma verdadeira obra-prima das armas no Counter-Strike: Global Offensive. Esta deslumbrante skin oferece não apenas poder letal, mas também uma estética hipnotizante que vai encantar qualquer jogador. Com sua serpente mítica e detalhes em ouro, a AWP | Medusa é a escolha definitiva para quem busca o equilíbrio perfeito entre estilo e desempenho no campo de batalha.",
                    ImagemUri = "/NovaPasta1/medusa.webp",
                    DataCadastro = DateTime.Now,
                    Preco = 13685.68,
                },
         };

        
    }
    public Skins Obter(int id)
    {
        return ObterTodos().SingleOrDefault(item => item.SkinsID == id);
    }
}
